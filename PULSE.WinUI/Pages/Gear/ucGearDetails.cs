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

namespace PULSE.WinUI.Pages.Gear
{
    public partial class ucGearDetails : UserControl
    {
        Model.Gear Model;

        public string TitleAdd { get; set; } = "Add Gear";
        public string TitleEdit { get; set; } = "Edit Gear";


        public delegate void GearUpsertHandler(GearUpsertRequest data, int ProductId);
        public event GearUpsertHandler ModelSubmitted;

        public ucGearDetails()
        {
            InitializeComponent();
        }

        public void ResetForm()
        {
            var textBoxes = Controls.OfType<TextBox>().ToList();
            foreach (var tb in textBoxes)
            {
                tb.Text = "";
            }

            var comboBoxes = Controls.OfType<ComboBox>().ToList();
            foreach (var cb in comboBoxes)
            {
                cb.SelectedIndex = 0;
            }

            rtbDescription.Text = "";
            nudQuantity.Value = nudQuantity.Minimum;

            var controls = Controls;
            foreach (Control control in controls)
            {
                errorProvider.SetError(control, "");
            }

            lblTitle.Text = TitleAdd;
        }

        public void SelectGear(Model.Gear model)
        {
            Model = model;

            tbProductNumber.Text = Model.ProductNumber;
            tbModel.Text = Model.Model;
            rtbDescription.Text = Model.Description;
            nudQuantity.Value = Model.AvailableQty ?? 0;
            nudPrice.Value = Model.Price ?? 1;

            var cbBrandItems = cbBrand.Items.OfType<Brand>().ToList();

            for (int i = 0; i < cbBrandItems.Count; i++)
            {
                if ((cbBrandItems[i] as Brand).BrandId == model.BrandId)
                {
                    cbBrand.SelectedIndex = i + 1;
                }
            }

            var cbCategoryItems = cbCategory.Items.OfType<ProductCategory>().ToList();

            for (int i = 0; i < cbCategoryItems.Count; i++)
            {
                if ((cbCategoryItems[i] as ProductCategory).ProductCategoryId == model.ProductCategoryId)
                {
                    cbCategory.SelectedIndex = i + 1;
                }
            }

            lblTitle.Text = TitleEdit;
        }

        public void LoadComboBoxes(List<Brand> brands, List<ProductCategory> categories)
        {
            cbBrand.Items.Add("Select Brand");
            foreach (var item in brands)
            {
                cbBrand.Items.Add(item);
            }

            cbCategory.Items.Add("Select a Category");
            foreach (var item in categories)
            {
                cbCategory.Items.Add(item);
            }
        }

        internal void ClearComboBoxes()
        {
            cbBrand.Items.Clear();
            cbCategory.Items.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ResetForm();
            (Parent as Panel).Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var req = new GearUpsertRequest()
                {
                    ProductNumber = tbProductNumber.Text,
                    Model = tbModel.Text,
                    BrandId = (cbBrand.SelectedItem as Brand).BrandId,
                    ProductCategoryId = (cbCategory.SelectedItem as ProductCategory).ProductCategoryId,
                    Description = rtbDescription.Text,
                    AvailableQty = Convert.ToInt32(nudQuantity.Value),
                    Price = nudPrice.Value
                };

                if (Model == null)
                {
                    ModelSubmitted.Invoke(req, -1);

                }
                else
                {
                    ModelSubmitted.Invoke(req, Model.ProductId);
                }

            }
        }

        #region Validation

        private void tbProductNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbProductNumber.Text))
            {
                e.Cancel = true;
                tbProductNumber.Focus();
                errorProvider.SetError(tbProductNumber, "Product number should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbProductNumber, "");
            }
        }

        private void cbBrand_Validating(object sender, CancelEventArgs e)
        {
            if (cbBrand.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(cbBrand, "Select a brand!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cbBrand, "");
            }
        }

        private void tbModel_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbModel.Text))
            {
                e.Cancel = true;
                tbModel.Focus();
                errorProvider.SetError(tbModel, "Model should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbModel, "");
            }
        }

        private void cbCategory_Validating(object sender, CancelEventArgs e)
        {
            if (cbCategory.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(cbCategory, "Select a category!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cbCategory, "");
            }
        }

        private void rtbDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                e.Cancel = true;
                rtbDescription.Focus();
                errorProvider.SetError(rtbDescription, "Description should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(rtbDescription, "");
            }
        }

        #endregion
    }
}
