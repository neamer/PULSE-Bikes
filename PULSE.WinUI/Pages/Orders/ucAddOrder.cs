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
    public partial class ucAddOrder : UserControl
    {
        public delegate void Select();
        public event Select OpenCustomerSelect;
        public event Select OpenBicycleSelect;
        public event Select OpenGearSelect;
        public event Select OpenPartSelect;

        public delegate void SubmitOrder(OrderHeaderInsertRequest req);
        public event SubmitOrder OnSubmit;

        public int CustomerID { get; set; } = -1;

        public ucAddOrder()
        {
            InitializeComponent();

            HorizontalScroll.Enabled = false;
        }

        protected override void OnLoad(EventArgs e)
        {
            tbCustomer.Enabled = false;
            EnableShippingDetails(false);
            CalculateTotals();


            base.OnLoad(e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pnlCustomer_Click(object sender, EventArgs e)
        {
            OpenCustomerSelect.Invoke();
        }

        private void tbModel_Click(object sender, EventArgs e)
        {
            OpenCustomerSelect.Invoke();
        }

        public void SelectCustomer(Model.Customer item)
        {
            tbCustomer.Text = $"{item.FirstName} {item.LastName}";
            CustomerID = item.Id;
        }

        public void SelectBicycle(Model.Bicycle item, Model.AvailableSize size)
        {
            var detail = new ProductDetailDGVItem()
            {
                ProductNumber = item.ProductNumber,
                Model = item.Model,
                ProductId = item.Id,
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



        public void SelectGear(Model.Gear item)
        {
            var detail = new ProductDetailDGVItem()
            {
                ProductNumber = item.ProductNumber,
                Model = item.Model,
                ProductId = item.Id,
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

        public void SelectPart(Model.Part item)
        {
            var detail = new ProductDetailDGVItem()
            {
                ProductNumber = item.ProductNumber,
                Model = item.Model,
                ProductId = item.Id,
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                var req = new OrderHeaderInsertRequest()
                {
                    OrderNumber = tbOrderNumber.Text,
                    CustomerId = CustomerID,
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

                var details = dgvAvailableSizes.DataSource as BindingSource;

                var list = new List<OrderDetailsAIOInsertRequest>();

                foreach (ProductDetailDGVItem item in details)
                {
                    list.Add(new OrderDetailsAIOInsertRequest()
                    {
                        ProductId = item.ProductId,
                        Quantity = item.Quantity,
                        BicycleSizeId = item.BicycleSizeId,
                        Discriminator = item.Discriminator
                    });
                }

                req.OrderDetails = list;

                OnSubmit.Invoke(req);
            }
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

        public void Reset()
        {
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

        private void tbCustomer_Validating(object sender, CancelEventArgs e)
        {
            if (CustomerID == -1)
            {
                e.Cancel = true;
                tbCustomer.Focus();
                errorProvider.SetError(tbCustomer, "Select a customer!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbCustomer, "");
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
                if(!StringHelper.IsDigitsOnly(e.FormattedValue.ToString()))
                {
                    e.Cancel = true;
                }
            }
        }

        private void dgvAvailableSizes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var details = dgvAvailableSizes.DataSource as BindingSource;

                var list = new List<ProductDetailDGVItem>();

                int i = 0;
                foreach(ProductDetailDGVItem item in details)
                {
                    if(i != e.RowIndex)
                    {
                        list.Add(item);
                    }
                    i++;
                }

                dgvAvailableSizes.DataSource = new BindingSource { DataSource = list };
                CalculateTotals();
            }
        }

        private void cbDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if(cbDelivery.Checked)
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

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

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
            if(cbDelivery.Checked)
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

        private void nudShippingCost_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void dgvAvailableSizes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalculateTotals();
        }
    }
}
