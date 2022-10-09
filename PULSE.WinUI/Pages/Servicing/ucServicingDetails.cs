using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.WinUI.Helpers;
using PULSE.WinUI.Pages.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PULSE.WinUI.Pages.Servicing
{
    public partial class ucServicingDetails : UserControl
    {
        public Model.Servicing Entity { get; set; }

        public APIService ServicingService = new APIService("Servicing");

        public delegate void Select();
        public event Select OpenPartSelect;
        public event Select Reload;

        public ucServicingDetails()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            tbCustomer.Enabled = false;
            tbStatus.Enabled = false;

            base.OnLoad(e);
        }

        protected override void SetVisibleCore(bool value)
        {
            if(value)
            {

            }
            else
            {
                Reset();
            }

            base.SetVisibleCore(value);
        }

        public void PendingReviewState()
        {
            pnlFlowOffer.Size = pnlFlowOffer.MinimumSize;
            pnlFlowOffer.Hide();

            lblAddOffer.Show();
            lblAddPart.Show();
            lblCancelOffer.Hide();
            lblSubmitOffer.Hide();

            dgvAvailableSizes.Enabled = true;
            dgvAvailableSizes.Columns["Remove"].Visible = true;
            nudLabourCost.Enabled = true;
            rtbRequest.Enabled = true;

            pnlButtonsReview.Size = pnlButtonsReview.MaximumSize;
            pnlButtonsReview.Show();

            pnlButtonsPayment.Size = pnlButtonsPayment.MinimumSize;
            pnlButtonsPayment.Hide();

            pnlButtonsServicing.Size = pnlButtonsServicing.MinimumSize;
            pnlButtonsServicing.Hide();
        }

        public void PendingPaymentState()
        {
            pnlFlowOffer.Size = pnlFlowOffer.MaximumSize;
            pnlFlowOffer.Show();

            lblAddOffer.Hide();
            lblCancelOffer.Hide();
            lblSubmitOffer.Hide();

            lblAddPart.Hide();

            dgvAvailableSizes.Enabled = false;
            dgvAvailableSizes.Columns["Remove"].Visible = false;
            nudLabourCost.Enabled = false;

            pnlButtonsReview.Size = pnlButtonsReview.MinimumSize;
            pnlButtonsReview.Hide();

            pnlButtonsPayment.Size = pnlButtonsPayment.MaximumSize;
            pnlButtonsPayment.Show();

            pnlButtonsServicing.Size = pnlButtonsServicing.MinimumSize;
            pnlButtonsServicing.Hide();
        }

        public void PendingServicingState()
        {
            pnlFlowOffer.Size = pnlFlowOffer.MaximumSize;
            pnlFlowOffer.Show();

            lblAddOffer.Hide();
            lblCancelOffer.Hide();
            lblSubmitOffer.Hide();

            lblAddPart.Hide();

            dgvAvailableSizes.Enabled = false;
            dgvAvailableSizes.Columns["Remove"].Visible = false;
            nudLabourCost.Enabled = false;

            pnlButtonsReview.Size = pnlButtonsReview.MinimumSize;
            pnlButtonsReview.Hide();

            pnlButtonsPayment.Size = pnlButtonsPayment.MinimumSize;
            pnlButtonsPayment.Hide();

            pnlButtonsServicing.Size = pnlButtonsServicing.MaximumSize;
            pnlButtonsServicing.Show();
        }

        public void CompletedCancelledState()
        {
            pnlFlowOffer.Size = pnlFlowOffer.MaximumSize;
            pnlFlowOffer.Show();

            lblAddOffer.Hide();
            lblCancelOffer.Hide();
            lblSubmitOffer.Hide();

            lblAddPart.Hide();

            dgvAvailableSizes.Enabled = false;
            dgvAvailableSizes.Columns["Remove"].Visible = false;
            nudLabourCost.Enabled = false;

            pnlButtonsReview.Size = pnlButtonsReview.MinimumSize;
            pnlButtonsReview.Hide();

            pnlButtonsPayment.Size = pnlButtonsPayment.MinimumSize;
            pnlButtonsPayment.Hide();

            pnlButtonsServicing.Size = pnlButtonsServicing.MinimumSize;
            pnlButtonsServicing.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            pnlFlowOffer.Show();
            pnlFlowOffer.Size = pnlFlowOffer.MaximumSize;

            EnableOfferEditing(true);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private async void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Cancel order", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var result = await ServicingService.Delete<Model.Servicing>(Entity.ServicingId);

                if (result != null)
                {
                    Entity.Status = (int)ServicingState.Cancelled;
                    tbStatus.Text = ServicingStateHelper.GetNameFromState((ServicingState)Entity.Status);
                    CompletedCancelledState();
                    Reload.Invoke();
                    MessageBox.Show("Successfully canceled servicing!");
                }
            }
        }

        public void Reset()
        {
            tbServicingNumber.Text = "";
            tbStatus.Text = "";
            tbCustomer.Text = "";
            rtbRequest.Text = "";
            dgvAvailableSizes.DataSource = new BindingSource() { DataSource = new List<ProductDetailDGVItem>() };
            nudLabourCost.Value = 0;
            rtbOfferDetails.Text = "";
        }

        public async void LoadDetails(int ServicingID)
        {
            Entity = await ServicingService.GetById<Model.Servicing>(ServicingID);

            if(Entity == null)
            {
                Hide();
            }

            LoadEntityIntoControls();
            
            if(Entity.Status == (int)ServicingState.PendingReview)
            {
                PendingReviewState();
            }
            else if(Entity.Status == (int)ServicingState.PendingPayment)
            {
                PendingPaymentState();

            }
            else if(Entity.Status == (int)ServicingState.PendingServicing)
            {
                PendingServicingState();
            }
            else
            {
                CompletedCancelledState();
            }
        }

        private void LoadEntityIntoControls()
        {
            tbServicingNumber.Text = Entity.ServicingNumber;
            tbStatus.Text = Model.ServicingStateHelper.GetNameFromState((Model.ServicingState)Entity.Status);
            tbCustomer.Text = Entity.Customer.ToString();
            rtbRequest.Text = Entity.CustomerRequest;

            if (Entity.ServicingParts.Count != 0)
            {
                var details = new List<ProductDetailDGVItem>();

                foreach (var detail in Entity.ServicingParts)
                {
                    details.Add(new ProductDetailDGVItem(detail));
                }

                dgvAvailableSizes.DataSource = new BindingSource() { DataSource = details };
            }

            if (Entity.OfferDetails != null)
            {
                rtbOfferDetails.Text = Entity.OfferDetails;
            }

            if (Entity.LabourCost != null)
            {
                nudLabourCost.Value = Entity.LabourCost ?? 0;
            }
        }

        private void lblCancelOffer_Click(object sender, EventArgs e)
        {
            pnlFlowOffer.Size = pnlFlowOffer.MinimumSize;
            pnlFlowOffer.Hide();

            lblAddOffer.Show();
            lblSubmitOffer.Hide();
            lblCancelOffer.Hide();
        }

        private async void lblSubmitOffer_Click(object sender, EventArgs e)
        {
            if (rtbOfferDetails_Validate())
            {
                var req = new ServicingOfferInsertRequest()
                {
                    OfferDetails = rtbOfferDetails.Text,
                    LabourCost = nudLabourCost.Value
                };

                var parts = dgvAvailableSizes.DataSource as BindingSource;

                var list = new List<ServicingPartBatchInsertRequest>();

                foreach (ProductDetailDGVItem item in parts)
                {
                    list.Add(new ServicingPartBatchInsertRequest()
                    {
                        ProductId = item.ProductId,
                        Quantity = item.Quantity,
                    });
                }

                req.ServicingParts = list;

                var result = await ServicingService.PostCustomPath<Model.Servicing>($"{Entity.ServicingId}/offer", req);

                if(result == null)
                {
                    return;
                }

                Entity.Status = (int)ServicingState.PendingPayment;
                tbStatus.Text = ServicingStateHelper.GetNameFromState((ServicingState)Entity.Status);

                PendingPaymentState();

                MessageBox.Show("The servicing offer has been sent to the customer successfully!", "Success", MessageBoxButtons.OK);
                Reload.Invoke();
            }
        }

        public void SelectPart(Model.Part item)
        {
            var detail = new ProductDetailDGVItem()
            {
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

        public void CalculateTotals()
        {
            var list = dgvAvailableSizes.DataSource as BindingSource;

            decimal itemTotal = 0;

            foreach (ProductDetailDGVItem item in list)
            {
                itemTotal += item.UnitPrice * item.Quantity;
            }

            lblParts.Text = itemTotal.ToString();

            lblLabour.Text = nudLabourCost.Value.ToString();
            lblGrandTotal.Text = (itemTotal + nudLabourCost.Value).ToString();
        }

        public void EnableOfferEditing(bool option)
        {
            lblAddOffer.Hide();
            lblSubmitOffer.Show();
            lblCancelOffer.Show();
        }

        private void tbServicingNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbServicingNumber.Text))
            {
                e.Cancel = true;
                tbServicingNumber.Focus();
                errorProvider.SetError(tbServicingNumber, "Servicing number should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbServicingNumber, "");
            }
        }

        private void rtbRequest_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbRequest.Text))
            {
                e.Cancel = true;
                rtbRequest.Focus();
                errorProvider.SetError(rtbRequest, "Request should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(rtbRequest, "");
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                var req = new ServicingUpdateRequest()
                {
                    ServicingNumber = tbServicingNumber.Text,
                    CustomerRequest = rtbRequest.Text
                };

                var result = await ServicingService.Put<Model.Servicing>(Entity.ServicingId, req);

                if(result != null)
                {
                    Entity.ServicingNumber = result.ServicingNumber;
                    Entity.CustomerRequest = result.CustomerRequest;

                    MessageBox.Show("Servicing Updated Successfully!", "Success", MessageBoxButtons.OK);
                    Reload.Invoke();
                }
            }
        }

        private void lblAddPart_Click(object sender, EventArgs e)
        {
            OpenPartSelect.Invoke();
        }

        private void nudLabourCost_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotals();
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
                foreach (ProductDetailDGVItem item in details)
                {
                    if (i != e.RowIndex)
                    {
                        list.Add(item);
                    }
                    i++;
                }

                dgvAvailableSizes.DataSource = new BindingSource { DataSource = list };
                CalculateTotals();
            }
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

        private void dgvAvailableSizes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalculateTotals();
        }

        private bool rtbOfferDetails_Validate()
        {
            if (string.IsNullOrWhiteSpace(rtbOfferDetails.Text))
            {
                rtbOfferDetails.Focus();
                errorProvider.SetError(rtbOfferDetails, "Offer details should not be left blank!");
                return false;
            }
            else
            {
                errorProvider.SetError(rtbOfferDetails, "");
                return true;
            }
        }

        private void rtbRequest_EnabledChanged(object sender, EventArgs e)
        {
            rtbOfferDetails.BackColor = Color.FromArgb(255, 53, 53, 64);
            rtbOfferDetails.ForeColor = Color.FromArgb(255, 173, 173, 177);
        }

        private void rtbRequest_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Entity.Status != (int)ServicingState.PendingReview)
            {
                e.Handled = true;
            }
        }

        private void rtbOfferDetails_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Entity.Status != (int)ServicingState.PendingReview)
            {
                e.Handled = true;
            }
        }

        private async void btnPayment_Click(object sender, EventArgs e)
        {
            var req = new PaymentInsertRequest()
            {
                Method = "LOCAL CASH"
            };

            var result = await ServicingService.PostCustomPath<Model.Servicing>($"{Entity.ServicingId}/RegisterPayment", req);

            if(result == null)
            {
                return;
            }

            this.Entity.Status = result.Status;
            tbStatus.Text = ServicingStateHelper.GetNameFromState((ServicingState)Entity.Status);

            PendingServicingState();

            MessageBox.Show("Payment Registered Successfully!", "Success", MessageBoxButtons.OK);
            Reload.Invoke();
        }

        private async void btnCancel2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Cancel order", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var result = await ServicingService.Delete<Model.Servicing>(Entity.ServicingId);

                if (result != null)
                {
                    Entity.Status = (int)ServicingState.Cancelled;
                    tbStatus.Text = ServicingStateHelper.GetNameFromState((ServicingState)Entity.Status);
                    CompletedCancelledState();
                    Reload.Invoke();
                    MessageBox.Show("Successfully canceled servicing!");
                }
            }
        }

        private async void btnCancel3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Cancel order", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var result = await ServicingService.Delete<Model.Servicing>(Entity.ServicingId);

                if (result != null)
                {
                    Entity.Status = (int)ServicingState.Cancelled;
                    tbStatus.Text = ServicingStateHelper.GetNameFromState((ServicingState)Entity.Status);
                    CompletedCancelledState();
                    Reload.Invoke();
                    MessageBox.Show("Successfully canceled servicing!");
                }
            }
        }

        private async void btnCompleted_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Complete Servicing?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var result = await ServicingService.PostCustomPath<Model.Servicing>($"{Entity.ServicingId}/Complete", Entity.ServicingId);

                if (result != null)
                {
                    Entity.Status = (int)ServicingState.Completed;
                    tbStatus.Text = ServicingStateHelper.GetNameFromState((ServicingState)Entity.Status);
                    CompletedCancelledState();
                    Reload.Invoke();
                    MessageBox.Show("Successfully completed servicing!");
                }
            }
        }
    }
}
