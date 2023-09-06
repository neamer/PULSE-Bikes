using PULSE.Model;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PULSE.WinUI.Pages.Staff
{
    public partial class ucAddStaff : UserControl
    {
        public delegate void StaffInsertHandler(StaffInsertRequest req);
        public event StaffInsertHandler onStaffInsert;

        public ucAddStaff()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        public void ResetRoles()
        {
            cbRole.Items.Clear();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                var req = new StaffInsertRequest
                {
                    FirstName = tbFirstName.Text,
                    LastName = tbLastName.Text,
                    Username = tbUsername.Text,
                    Email = tbEmail.Text,
                    Password = tbPassword.Text,
                    PasswordConfirm = tbPasswordConfirm.Text,
                    RoleID = (cbRole.SelectedItem as Role).Id,
                    PhoneNumber = tbPhoneNumber.Text,
                    DateOfBirth = dtpDateOfBirth.Value,
                    DateOfEmployment = dtpDateOfEmployment.Value,
                };

                onStaffInsert.Invoke(req);
            }
        }

        public void LoadRoles(List<Role> list)
        {
            cbRole.Items.Add("Select Role");
            ComboBoxHelpers.LoadComboBoxItems(cbRole, list);
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

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                e.Cancel = true;
                tbPassword.Focus();
                errorProvider.SetError(tbPassword, "Password should not be left blank!");
            }
            else if (tbPassword.Text.Count() < 4)
            {
                e.Cancel = true;
                tbPassword.Focus();
                errorProvider.SetError(tbPassword, "Password need to be at least 4 characters long!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbPassword, "");
            }
        }

        private void tbPasswordConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPasswordConfirm.Text))
            {
                e.Cancel = true;
                tbPasswordConfirm.Focus();
                errorProvider.SetError(tbPasswordConfirm, "Password Confirm should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbPasswordConfirm, "");
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
        private void cbRole_Validating(object sender, CancelEventArgs e)
        {
            if (cbRole.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(cbRole, "Select a role!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cbRole, "");
            }
        }

        #endregion

    }
}
