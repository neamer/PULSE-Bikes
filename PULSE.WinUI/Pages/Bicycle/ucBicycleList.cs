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
    public partial class ucBicycleList : UserControl
    {

        public APIService BicycleService { get; set; } = new APIService("Bicycle");
        public APIService BicycleCategoryService { get; set; } = new APIService("BicycleCategory");
        public APIService BrandService { get; set; } = new APIService("Brand");


        public ucBicycleList()
        {
            InitializeComponent();

        }

        protected override void OnLoad(EventArgs e)
        {
            ucBicycleDetails1.ModelSubmitted += SubmitBicycle;

            base.OnLoad(e);
        }

        protected override void SetVisibleCore(bool value)
        {
            if (EnvironmentHelper.IsInRuntimeMode(this))
            {
                if (value)
                {
                    LoadComboBoxes();
                    pnlDetails.Visible = false;

                    loadData();
                }
                else
                {
                    ClearData();
                }
            }

            base.SetVisibleCore(value);
        }

        private void ClearData()
        {
            dgvBicycleList.DataSource = null;
            cbBrand.Items.Clear();
            cbCategory.Items.Clear();

            ucBicycleDetails1.ClearComboBoxes();
        }

        private async void LoadComboBoxes()
        {
            var brands = await BrandService.Get<List<Brand>>();
            cbBrand.Items.Add("Select Brand");
            ComboBoxHelpers.LoadComboBoxItems<Brand>(cbBrand, brands);


            var categories = await BicycleCategoryService.Get<List<ProductCategory>>();
            cbCategory.Items.Add("Select a Category");
            ComboBoxHelpers.LoadComboBoxItems<ProductCategory>(cbCategory, categories);

            ucBicycleDetails1.LoadComboBoxes(brands, categories);
        }



        private async void loadData()
        {
            var searchObject = new BicycleSearchObject()
            {
                IncludeBrand = true,
                IncludeCategory = true,
                IncludeSizes = true,
                AnyField = tbSearch.Text,
            };

            if (cbBrand.SelectedIndex != 0 && cbBrand.SelectedIndex != -1)
            {
                searchObject.BrandId = (cbBrand.SelectedItem as Brand).Id;
            }

            if (cbCategory.SelectedIndex != 0 && cbCategory.SelectedIndex != -1)
            {
                searchObject.ProductCategoryId = (cbCategory.SelectedItem as ProductCategory).Id;
            }

            var list = await BicycleService.Get<List<Model.Bicycle>>(searchObject);

            if (list == null)
            {
                return;
            }

            dgvBicycleList.DataSource = list;
        }

        private void cbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxHelpers.SetComboBoxPlaceholderColor(cbBrand);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxHelpers.SetComboBoxPlaceholderColor(cbCategory);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlDetails.Visible = true;
            ucBicycleDetails1.DisableDGV();
        }

        private async void SubmitBicycle(BicycleUpsertRequest data, int productId = -1)
        {
            if (productId == -1)
            {
                var item = await BicycleService.Post<Model.Bicycle>(data);

                if (item == null)
                {
                    return;
                }

                MessageBox.Show("Bicycle Added Successfully!");
            }
            else
            {
                var item = await BicycleService.Put<Model.Bicycle>(productId, data);

                if (item == null)
                {
                    return;
                }

                MessageBox.Show("Bicycle Updated Successfully!");
            }

            pnlDetails.Visible = false;
            loadData();
        }

        private void dgvBicycleList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvBicycleList.Rows[e.RowIndex].DataBoundItem as Model.Bicycle;

            ucBicycleDetails1.SelectBike(item);
            pnlDetails.Visible = true;
        }
    }
}
