using PULSE.Model.Requests;
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
    public partial class ucAddServicing : UserControl
    {
        public int CustomerID { get; set; } = -1;

        public delegate void Select();
        public event Select OpenCustomerSelect;

        public delegate void AddServicingHandler(RegisterServicingRequest req);
        public event AddServicingHandler onRegister;

        public ucAddServicing()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public void SelectCustomer(Model.Customer item)
        {
            tbCustomer.Text = $"{item.FirstName} {item.LastName}";
            CustomerID = item.CustomerId;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                var req = new RegisterServicingRequest()
                {
                    ServicingNumber = tbServicingNumber.Text,
                    CustomerId = CustomerID,
                    CustomerRequest = rtbRequest.Text
                };

                onRegister.Invoke(req);
            }
        }

        private void pnlCustomer_Click(object sender, EventArgs e)
        {
            OpenCustomerSelect.Invoke();
        }

        private void tbCustomer_Click(object sender, EventArgs e)
        {
            OpenCustomerSelect.Invoke();
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

        public void Reset()
        {
            CustomerID = -1;
            tbServicingNumber.Text = "";
            tbCustomer.Text = "";
            rtbRequest.Text = "";

            var controls = Controls;
            foreach (Control control in controls)
            {
                errorProvider.SetError(control, "");
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
    }
}
