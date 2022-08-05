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

namespace PULSE.WinUI.Pages.Bicycle
{
    public partial class ucBicycleSizeDetails : UserControl
    {
        public BicycleSize Model;

        public string TitleAdd { get; set; } = "Add a New Bicycle Size";
        public string TitleEdit { get; set; } = "Edit Bicycle Size";

        public delegate void BicycleUpsertHandler(BicycleSizeUpsertRequest data, int categoryID);
        public event BicycleUpsertHandler ModelSubmitted;

        public ucBicycleSizeDetails()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {

                var req = new BicycleSizeUpsertRequest()
                {
                    Size = tbName.Text
                };

                if (Model != null)
                {
                    ModelSubmitted.Invoke(req, Model.BicycleSizeId);
                }
                else
                {
                    ModelSubmitted.Invoke(req, -1);
                }
            }
        }

        public void ResetData()
        {
            tbName.Text = "";

            errorProvider.SetError(tbName, "");

            lblTitle.Text = TitleAdd;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                e.Cancel = true;
                tbName.Focus();
                errorProvider.SetError(tbName, "Bicycle size should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbName, "");
            }
        }

        public void SelectCategory(BicycleSize model)
        {
            Model = model;

            tbName.Text = model.Size;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ResetData();
            (Parent as Panel).Visible = false;
        }
    }
}
