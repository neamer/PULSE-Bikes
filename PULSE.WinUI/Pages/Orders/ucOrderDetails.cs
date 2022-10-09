using PULSE.Model.Requests;
using PULSE.WinUI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PULSE.WinUI.Pages.Orders
{
    public partial class ucOrderDetails : UserControl
    {
        public int OrderID { get; set; }
        public Model.OrderHeader Item { get; set; }
        public int CustomerID { get; set; }
        public int? ShippingInfoID { get; set; }

        public APIService OrderService23 { get; set; } = new APIService("Order");
        public APIService OrderDetailBicycleService { get; set; } = new APIService("OrderDetailBicycle");
        public APIService OrderDetailGearService { get; set; } = new APIService("OrderDetailGear");
        public APIService OrderDetailPartService { get; set; } = new APIService("OrderDetailPart");

        public delegate void Select();
        public event Select OpenBicycleSelect;
        public event Select OpenGearSelect;
        public event Select OpenPartSelect;

        public event Select Reload;
        public event Select ReloadDetails;

        public ucOrderDetails()
        {
            InitializeComponent();
        }

        protected override void SetVisibleCore(bool value)
        {
            if (value)
            {
            }
            else
            {
                if(OrderID != -1)
                {
                    Reload.Invoke();
                    Reset();
                }
            }

            base.SetVisibleCore(value);
        }

        public void SetButtons(Panel buttons)
        {
            foreach (var item in flpButtons.Controls)
            {
                if(item == buttons)
                {
                    (item as Panel).Size = (item as Panel).MaximumSize;
                }
                else
                {
                    (item as Panel).Size = (item as Panel).MinimumSize;
                }
            }
        }

        public async void LoadOrder(Model.OrderHeader item)
        {
            if (item == null)
            {
                return;
            }

            SetOrder(item);

            switch ((Model.OrderState)item.Status)
            {
                case Model.OrderState.Draft:
                    EnableEditing();
                    SetButtons(pblDraftButtons);
                    break;

                case Model.OrderState.Processed:
                    DisableEditing();
                    SetButtons(pnlProcessedButtons);
                    break;

                case Model.OrderState.Cancelled:
                    DisableEditing();
                    SetButtons(pnlBottomPadding);
                    break;
                case Model.OrderState.Delivered:
                    DisableEditing();
                    SetButtons(pnlDeliveredButtons);
                    break;

                default:
                    break;
            }
        }

        public void Reset()
        {
            OrderID = -1;
            Item = null;

            tbOrderNumber.Text = "";
            tbCustomer.Text = "";
            CustomerID = -1;
            dgvAvailableSizes.DataSource = new BindingSource();
            cbDelivery.Checked = false;
            tbCountry.Text = "";
            tbState.Text = "";
            tbCity.Text = "";
            tbZipCode.Text = "";
            tbStreetAddress.Text = "";

            var controls = Controls;
            foreach (Control control in controls)
            {
                errorProvider.SetError(control, "");
            }

            CalculateTotals();
        }

        public void SetOrder(Model.OrderHeader item)
        {
            Item = item;
            tbOrderNumber.Text = item.OrderNumber;
            if(item.Customer != null)
            {
                tbCustomer.Text = item.Customer?.ToString();
                CustomerID = item.CustomerId ?? -1;
            }
            cbDelivery.Checked = item.Delivery ?? false;
            ShippingInfoID = item.ShippingInfoId;
            tbCountry.Text = item.ShippingInfo?.Country;
            tbState.Text = item.ShippingInfo?.StateOrProvince;
            tbCity.Text = item.ShippingInfo?.City;
            tbZipCode.Text = item.ShippingInfo?.ZipCode;
            tbStreetAddress.Text = item.ShippingInfo?.StreetAddress;
            nudShippingCost.Value = item.ShippingConst ?? 0;

            if (item.OrderDetails.Count != 0)
            {
                var details = new List<ProductDetailDGVItem>();

                foreach (var detail in item.OrderDetails)
                {
                    details.Add(new ProductDetailDGVItem(detail));
                }

                dgvAvailableSizes.DataSource = new BindingSource() { DataSource = details };
            }

            CalculateTotals();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var req = new OrderHeaderUpdateRequest()
                {
                    OrderNumber = tbOrderNumber.Text,
                    OnlineOrder = false
                };

                req.Delivery = cbDelivery.Checked;

                if (req.Delivery)
                {

                    req.ShippingConst = nudShippingCost.Value;
                    req.ShippingInfo = new ShippingInfoUpsertRequest()
                    {
                        Country = tbCountry.Text,
                        StateOrProvince = tbState.Text,
                        City = tbCity.Text,
                        ZipCode = tbZipCode.Text,
                        StreetAddress = tbStreetAddress.Text,
                    };
                }


                var item = await OrderService23.Put<Model.OrderHeader>(OrderID, req);

                if (item == null)
                {
                    return;
                }

                SetOrder(item);
            }
        }

        private void cbDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDelivery.Checked)
            {
                EnableShippingDetails(true);
            }
            else
            {
                EnableShippingDetails(false);
            }
            CalculateTotals();
        }

        private void EnableShippingDetails(bool option)
        {
            tbCountry.Enabled = option;
            tbState.Enabled = option;
            tbCity.Enabled = option;
            tbZipCode.Enabled = option;
            tbStreetAddress.Enabled = option;
        }

        public void CalculateTotals()
        {
            var list = dgvAvailableSizes.DataSource as BindingSource;

            decimal itemTotal = 0;

            foreach (ProductDetailDGVItem item in list)
            {
                itemTotal += item.UnitPrice * item.Quantity;
            }

            lblItemTotal.Text = itemTotal.ToString();
            if (cbDelivery.Checked)
            {
                lblShipping.Text = nudShippingCost.Value.ToString();
                lblGrandTotal.Text = (itemTotal + nudShippingCost.Value).ToString();
            }
            else
            {
                lblShipping.Text = "Shipping not checked";
                lblGrandTotal.Text = itemTotal.ToString();
            }
        }

        #region Validation

        private void tbOrderNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbOrderNumber.Text))
            {
                e.Cancel = true;
                tbOrderNumber.Focus();
                errorProvider.SetError(tbOrderNumber, "Order number should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbOrderNumber, "");
            }
        }

        private void tbCountry_Validating(object sender, CancelEventArgs e)
        {
            if (cbDelivery.Checked && string.IsNullOrWhiteSpace(tbCountry.Text))
            {
                e.Cancel = true;
                tbCountry.Focus();
                errorProvider.SetError(tbCountry, "Country should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbCountry, "");
            }
        }

        private void tbState_Validating(object sender, CancelEventArgs e)
        {
            if (cbDelivery.Checked && string.IsNullOrWhiteSpace(tbState.Text))
            {
                e.Cancel = true;
                tbState.Focus();
                errorProvider.SetError(tbState, "State should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbState, "");
            }
        }

        private void tbCity_Validating(object sender, CancelEventArgs e)
        {
            if (cbDelivery.Checked && string.IsNullOrWhiteSpace(tbCity.Text))
            {
                e.Cancel = true;
                tbCity.Focus();
                errorProvider.SetError(tbCity, "City should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbCity, "");
            }
        }

        private void tbZipCode_Validating(object sender, CancelEventArgs e)
        {
            if (cbDelivery.Checked && string.IsNullOrWhiteSpace(tbZipCode.Text))
            {
                e.Cancel = true;
                tbZipCode.Focus();
                errorProvider.SetError(tbZipCode, "Zip code should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbZipCode, "");
            }
        }

        private void tbStreetAddress_Validating(object sender, CancelEventArgs e)
        {
            if (cbDelivery.Checked && string.IsNullOrWhiteSpace(tbStreetAddress.Text))
            {
                e.Cancel = true;
                tbStreetAddress.Focus();
                errorProvider.SetError(tbStreetAddress, "Street address should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbStreetAddress, "");
            }
        }

        #endregion

        private void nudShippingCost_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private async void dgvAvailableSizes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var item = (dgvAvailableSizes.Rows[e.RowIndex].DataBoundItem as ProductDetailDGVItem);

            var req = new OrderDetailsUpdateRequest()
            {
                Quantity = item.Quantity
            };

            var result = await OrderService23.PutCustomPath<Model.OrderDetail>("detail", item.OrderDetailId, req);

            if(result == null)
            {
                item.Quantity = Item.OrderDetails.Where(x => x.OrderDetailId == item.OrderDetailId).First().Quantity ?? 0;
                return;
            }
            CalculateTotals();
        }

        public async void AddBicycle(Model.Bicycle item, Model.AvailableSize size)
        {
            var req = new OrderDetailBicycleInsertRequest()
            {
                OrderId = OrderID,
                ProductId = item.ProductId,
                BicycleSizeId = size.BicycleSizeId,
                Quantity = 1,
            };

            var result = await OrderDetailBicycleService.Post<Model.OrderDetail>(req);

            if(result == null)
            {
                return;
            }

            var detail = new ProductDetailDGVItem()
            {
                OrderDetailId = result.OrderDetailId,
                ProductNumber = item.ProductNumber,
                Model = item.Model,
                ProductId = item.ProductId,
                UnitPrice = item.Price ?? 0,
                Size = size.BicycleSize.Size,
                BicycleSizeId = size.BicycleSizeId,
                Quantity = 1,
                Discriminator = "Bicycle"
            };

            var list = dgvAvailableSizes.DataSource as BindingSource;

            list.Add(detail);

            dgvAvailableSizes.DataSource = list;

            CalculateTotals();
        }

        public async void SelectGear(Model.Gear item)
        {
            var req = new OrderDetailsInsertRequest()
            {
                OrderId = OrderID,
                ProductId = item.ProductId,
                Quantity = 1,
            };

            var result = await OrderDetailGearService.Post<Model.OrderDetail>(req);

            if (result == null)
            {
                return;
            }

            var detail = new ProductDetailDGVItem()
            {
                OrderDetailId = result.OrderDetailId,
                ProductNumber = item.ProductNumber,
                Model = item.Model,
                ProductId = item.ProductId,
                UnitPrice = item.Price ?? 0,
                Size = "-",
                Quantity = 1,
                Discriminator = "Gear"
            };

            var list = dgvAvailableSizes.DataSource as BindingSource;

            list.Add(detail);

            dgvAvailableSizes.DataSource = list;

            CalculateTotals();
        }

        public async void SelectPart(Model.Part item)
        {
            var req = new OrderDetailsInsertRequest()
            {
                OrderId = OrderID,
                ProductId = item.ProductId,
                Quantity = 1,
            };

            var result = await OrderDetailPartService.Post<Model.OrderDetail>(req);

            if (result == null)
            {
                return;
            }

            var detail = new ProductDetailDGVItem()
            {
                OrderDetailId = result.OrderDetailId,
                ProductNumber = item.ProductNumber,
                Model = item.Model,
                ProductId = item.ProductId,
                UnitPrice = item.Price ?? 0,
                Size = "-",
                Quantity = 1,
                Discriminator = "Part"
            };

            var list = dgvAvailableSizes.DataSource as BindingSource;

            list.Add(detail);

            dgvAvailableSizes.DataSource = list;

            CalculateTotals();
        }

        private void lblAddBike_Click(object sender, EventArgs e)
        {
            OpenBicycleSelect.Invoke();
        }

        private void lblAddGear_Click(object sender, EventArgs e)
        {
            OpenGearSelect.Invoke();
        }

        private void lblAddPart_Click(object sender, EventArgs e)
        {
            OpenPartSelect.Invoke();
        }

        private void dgvAvailableSizes_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dgvAvailableSizes.CurrentCell.ColumnIndex == 3) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvAvailableSizes_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 3) //Desired Column
            {
                if (!StringHelper.IsDigitsOnly(e.FormattedValue.ToString()))
                {
                    e.Cancel = true;
                }
            }
        }

        private async void dgvAvailableSizes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var item = (dgvAvailableSizes.Rows[e.RowIndex].DataBoundItem as ProductDetailDGVItem);

                var result = await OrderService23.DeleteCustomPath<Model.OrderDetail>("detail", item.OrderDetailId);

                if(result == null)
                {
                    return;
                }

                var details = dgvAvailableSizes.DataSource as BindingSource;

                var list = new List<ProductDetailDGVItem>();

                int i = 0;
                foreach (ProductDetailDGVItem detail in details)
                {
                    if (i != e.RowIndex)
                    {
                        list.Add(detail);
                    }
                    i++;
                }

                dgvAvailableSizes.DataSource = new BindingSource { DataSource = list };
                CalculateTotals();
            }
        }

        private async void btnProcess_Click(object sender, EventArgs e)
        {
            var req = new PaymentInsertRequest()
            {
                Method = "LOCAL CASH",
            };

            var item = await OrderService23.PostCustomPath<HttpStatusMessage> ($"process/{OrderID}", req);

            if(item != null)
            {
                MessageBox.Show("Successfully processed order!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReloadDetails.Invoke();
                Reload.Invoke();
            }
        }

        public void DisableEditing()
        {
            tbOrderNumber.Enabled = false;
            dgvAvailableSizes.Enabled = false;
            dgvAvailableSizes.Columns["Remove"].Visible = false;
            cbDelivery.AutoCheck = false;
            EnableShippingDetails(false);

            lblAddBike.Hide();
            lblAddGear.Hide();
            lblAddPart.Hide();
        }

        public void EnableEditing()
        {
            tbOrderNumber.Enabled = true;
            dgvAvailableSizes.Enabled = true;
            dgvAvailableSizes.Columns["Remove"].Visible = true;
            cbDelivery.AutoCheck = true;
            EnableShippingDetails(true);

            lblAddBike.Show();
            lblAddGear.Show();
            lblAddPart.Show();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Delete order", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var result = await OrderService23.Delete<Model.OrderHeader>(OrderID);

                if(result != null)
                {
                    Hide();
                    Reset();
                    Reload.Invoke();
                    MessageBox.Show("Successfully removed order!");
                }
            }
        }

        private async void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Cancel order", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var result = await OrderService23.DeleteCustomPath<Model.OrderHeader>("cancel", OrderID);

                if (result != null)
                {
                    ReloadDetails.Invoke();
                    Reload.Invoke();
                    MessageBox.Show("Successfully canceled order!");
                }
            }
        }

        private void btnShipping_Click(object sender, EventArgs e)
        {
            var frm = new frmShippingStatus(Item);
            frm.StatusChange += ShippingNextStep;
            frm.Show();
        }

        public async void ShippingNextStep(frmShippingStatus frm)
        {
            switch ((Model.OrderState)Item.Status)
            {
                case Model.OrderState.Processed:

                    var itemProcessed = await OrderService23.PostCustomPath<Model.OrderHeader>($"pack/{OrderID}", new object());

                    if (itemProcessed != null)
                    {
                        Item.TimePacked = itemProcessed.TimePacked;
                        Item.Status = itemProcessed.Status;

                        frm.order = Item;
                        frm.Refresh();

                        return;
                    }

                    break;

                case Model.OrderState.Packed:

                    var itemPacked = await OrderService23.PostCustomPath<Model.OrderHeader>($"ship/{OrderID}", new object());

                    if (itemPacked != null)
                    {
                        Item.TimeShipped = itemPacked.TimeShipped;
                        Item.Status = itemPacked.Status;

                        frm.order = Item;
                        frm.Refresh();

                        return;
                    }

                    break;

                case Model.OrderState.Shipped:

                    var itemShipped = await OrderService23.PostCustomPath<Model.OrderHeader>($"deliver/{OrderID}", new object());

                    if (itemShipped != null)
                    {
                        Item.TimeDelivered = itemShipped.TimeDelivered;
                        Item.Status = itemShipped.Status;

                        frm.order = Item;
                        frm.Refresh();

                        return;
                    }

                    break;

                case Model.OrderState.Delivered:
                    return;
                    break;

                default:
                    break;
            }

            MessageBox.Show("Could not process order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void lblRemoveShipping_Click(object sender, EventArgs e)
        {
            if(Item.ShippingInfoId != null)
            {
                var result = await OrderService23.DeleteCustomPath<HttpStatusMessage>("shippinginfo", Item.OrderId);

                if(result.Success)
                {
                    cbDelivery.Checked = false;
                    tbCountry.Text = "";
                    tbState.Text = "";
                    tbCity.Text = "";
                    tbZipCode.Text = "";
                    tbStreetAddress.Text = "";
                }
            }
        }
    }
}
