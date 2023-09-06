using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
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

namespace PULSE.WinUI.Pages.Bicycle
{
    public partial class ucBicycleDetails : UserControl
    {

        public APIService AvailableSizeService { get; set; } = new APIService("AvailableSize");

        Model.Bicycle Model;

        public string TitleAdd { get; set; } = "Add a New Bicycle";
        public string TitleEdit { get; set; } = "Edit Bicycle";


        public delegate void BicycleUpsertHandler(BicycleUpsertRequest data, int ProductId);
        public event BicycleUpsertHandler ModelSubmitted;

        public ucBicycleDetails()
        {
            InitializeComponent();
        }

        public async void LoadSizes()
        {
            var searchObject = new AvailableSizeSearchObject()
            {
                ProductId = Model.Id
            };

            var items = await AvailableSizeService.Get<List<AvailableSize>>(searchObject);

            if (items == null)
            {
                return;
            }

            dgvAvailableSizes.DataSource = items;
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
            nudPrice.Value = nudPrice.Minimum;
            nudWeight.Value = nudWeight.Minimum;
            nudProductionYear.Value = 2022;

            var controls = Controls;
            foreach (Control control in controls)
            {
                errorProvider.SetError(control, "");
            }

            lblTitle.Text = TitleAdd;
            Model = null;
        }

        public void SelectBike(Model.Bicycle model)
        {
            Model = model;

            tbProductNumber.Text = Model.ProductNumber;
            tbModel.Text = Model.Model;
            rtbDescription.Text = Model.Description;
            tbWheelSize.Text = Model.WheelSize;
            nudWeight.Value = Model.Weight ?? 1;
            nudProductionYear.Value = Model.ProductionYear ?? 2022;
            nudPrice.Value = Model.Price ?? 1;

            var cbBrandItems = cbBrand.Items.OfType<Brand>().ToList();

            for (int i = 0; i < cbBrandItems.Count; i++)
            {
                if ((cbBrandItems[i] as Brand).Id == model.BrandId)
                {
                    cbBrand.SelectedIndex = i + 1;
                }
            }

            var cbCategoryItems = cbCategory.Items.OfType<ProductCategory>().ToList();

            for (int i = 0; i < cbCategoryItems.Count; i++)
            {
                if ((cbCategoryItems[i] as ProductCategory).Id == model.ProductCategoryId)
                {
                    cbCategory.SelectedIndex = i + 1;
                }
            }

            lblTitle.Text = TitleEdit;

            dgvAvailableSizes.Enabled = true;
            LoadSizes();
        }

        public void DisableDGV()
        {
            dgvAvailableSizes.Enabled = false;
        }

        internal void ClearComboBoxes()
        {
            cbBrand.Items.Clear();
            cbCategory.Items.Clear();
        }

        private void ucBicycleDetails_Load(object sender, EventArgs e)
        {

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            ResetForm();
            (Parent as Panel).Visible = false;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                BicycleUpsertRequest req = new BicycleUpsertRequest()
                {
                    ProductNumber = tbProductNumber.Text,
                    Model = tbModel.Text,
                    BrandId = (cbBrand.SelectedItem as Brand).Id,
                    ProductCategoryId = (cbCategory.SelectedItem as ProductCategory).Id,
                    Description = rtbDescription.Text,
                    WheelSize = tbWheelSize.Text,
                    Weight = nudWeight.Value,
                    ProductionYear = Convert.ToInt32(nudProductionYear.Value),
                    Price = nudPrice.Value
                };

                if (Model == null)
                {
                    ModelSubmitted.Invoke(req, -1);

                }
                else
                {
                    ModelSubmitted.Invoke(req, Model.Id);
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

        private void tbWheelSize_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbWheelSize.Text))
            {
                e.Cancel = true;
                tbWheelSize.Focus();
                errorProvider.SetError(tbWheelSize, "Wheel Size should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbWheelSize, "");
            }
        }

        #endregion

        private void label1_Click(object sender, EventArgs e)
        {
            if (Model != null)
            {
                var frm = new frmAvailableSizeDetails(Model.Id);

                frm.Show();
                frm.ModelSubmitted += LoadSizes;
            }
        }

        private void dgvAvailableSizes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvAvailableSizes.Rows[e.RowIndex].DataBoundItem as Model.AvailableSize;

            var frm = new frmAvailableSizeDetails(Model.Id, item);

            frm.Show();
            frm.ModelSubmitted += LoadSizes;
        }

        private void lblAddImage_Click(object sender, EventArgs e)
        {
            var frm = new frmAddImage();

            frm.Show();
        }
    }
}
