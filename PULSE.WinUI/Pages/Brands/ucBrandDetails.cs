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

namespace PULSE.WinUI.Pages.Brands
{
    public partial class ucBrandDetails : UserControl
    {
        public Brand Model;

        public string TitleAdd { get; set; } = "Add a New Brand";
        public string TitleEdit { get; set; } = "Edit Brand";

        public delegate void BrandUpsertHandler(BrandUpsertRequest data, int categoryID);
        public event BrandUpsertHandler ModelSubmitted;

        public ucBrandDetails()
        {
            InitializeComponent();
        }

        public void ResetData()
        {
            tbName.Text = "";

            errorProvider.SetError(tbName, "");            

            lblTitle.Text = TitleAdd;
        }

        public void SelectBrand(Brand model)
        {
            Model = model;

            tbName.Text = model.Name;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ResetData();
            (Parent as Panel).Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var req = new BrandUpsertRequest()
                {
                    Name = tbName.Text
                };

                if (Model != null)
                {
                    ModelSubmitted.Invoke(req, Model.Id);
                }
                else
                {
                    ModelSubmitted.Invoke(req, -1);
                }
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                e.Cancel = true;
                tbName.Focus();
                errorProvider.SetError(tbName, "Brand name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbName, "");
            }
        }
    }
}
