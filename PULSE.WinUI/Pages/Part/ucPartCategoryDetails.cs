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

namespace PULSE.WinUI.Pages.Part
{
    public partial class ucPartCategoryDetails : UserControl
    {
        public ProductCategory Model;

        public string TitleAdd { get; set; } = "Add a New Part Category";
        public string TitleEdit { get; set; } = "Edit Part Category";

        public delegate void PartUpsertHandler(ProductCategoryUpsertRequest data, int categoryID);
        public event PartUpsertHandler ModelSubmitted;

        public ucPartCategoryDetails()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {

                var req = new ProductCategoryUpsertRequest()
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
                errorProvider.SetError(tbName, "Product number should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbName, "");
            }
        }

        public void SelectCategory(ProductCategory model)
        {
            Model = model;

            tbName.Text = model.Name;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ResetData();
            (Parent as Panel).Visible = false;
        }
    }
}
