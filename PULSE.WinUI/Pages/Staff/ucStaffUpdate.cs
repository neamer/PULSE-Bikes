using PULSE.Model;
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

namespace PULSE.WinUI.Pages.Staff
{
    public partial class ucStaffUpdate : UserControl
    {
        public delegate void StaffUpdateHandler(int id, StaffUpdateRequest req);
        public event StaffUpdateHandler onStaffUpdate;

        public int StaffId { get; set; }

        public ucStaffUpdate()
        {
            InitializeComponent();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public void LoadEntity(Model.Staff staff)
        {
            tbFirstName.Text = staff.FirstName;
            tbLastName.Text = staff.LastName;
            tbUsername.Text = staff.Username;
            tbEmail.Text = staff.Email;
            tbPhoneNumber.Text = staff.PhoneNumber;
            dtpDateOfBirth.Value = staff.DateOfBirth ?? DateTime.Now;
            dtpDateOfEmployment.Value = staff.DateOfEmployment ?? DateTime.Now;

            cbStatus.SelectedIndex = (staff.Status ?? false) ? 0 : 1;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                var req = new StaffUpdateRequest()
                {
                    FirstName = tbFirstName.Text,
                    LastName = tbLastName.Text,
                    Email = tbEmail.Text,
                    PhoneNumber = tbPhoneNumber.Text,
                    Status = cbStatus.SelectedIndex == 0 ? true : false,
                };

                onStaffUpdate.Invoke(StaffId, req);
            }
        }

        #region Validation

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                e.Cancel = true;
                tbFirstName.Focus();
                errorProvider.SetError(tbFirstName, "First name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbFirstName, "");
            }
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbLastName.Text))
            {
                e.Cancel = true;
                tbLastName.Focus();
                errorProvider.SetError(tbLastName, "Last name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbLastName, "");
            }
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                e.Cancel = true;
                tbUsername.Focus();
                errorProvider.SetError(tbUsername, "Username should not be left blank!");
            }
            else if (tbUsername.Text.Count() < 4)
            {
                e.Cancel = true;
                tbUsername.Focus();
                errorProvider.SetError(tbUsername, "Username need to be at least 4 characters long!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbUsername, "");
            }
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                e.Cancel = true;
                tbEmail.Focus();
                errorProvider.SetError(tbEmail, "Email should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbEmail, "");
            }
        }

        private void tbPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPhoneNumber.Text))
            {
                e.Cancel = true;
                tbPhoneNumber.Focus();
                errorProvider.SetError(tbPhoneNumber, "Phone number should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbPhoneNumber, "");
            }
        }

        #endregion
    }
}
