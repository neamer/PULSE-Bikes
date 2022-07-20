using PULSE.Model;
using PULSE.Model.SearchObjects;
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

        private async void LoadCategories()
        {
            cbCategory.SelectedIndex = 0;

            var list = await BicycleCategoryService.Get<List<ProductCategory>>();

            foreach (var item in list)
            {
                cbCategory.Items.Add(item);
            }
        }

        private async void LoadBrands()
        {
            cbBrand.SelectedIndex = 0;

            var list = await BrandService.Get<List<Brand>>();

            foreach (var item in list)
            {
                cbBrand.Items.Add(item);
            }
        }

        protected override void SetVisibleCore(bool value)
        {
            if (value)
            {
                LoadBrands();
                LoadCategories();
                pnlDetails.Visible = false;

                loadData();
            }

            base.SetVisibleCore(value);
        }

        private async void loadData()
        {
            var searchObject = new BicycleSearchObject()
            {
                IncludeBrand = true,
                IncludeCategory = true,
                AnyField = tbSearch.Text,
            };

            if (cbBrand.SelectedIndex != 0)
            {
                searchObject.BrandId = (cbBrand.SelectedItem as Brand).BrandId;
            }

            if (cbCategory.SelectedIndex != 0)
            {
                searchObject.ProductCategoryId = (cbCategory.SelectedItem as ProductCategory).ProductCategoryId;
            }

            var list = await BicycleService.Get<List<Model.Bicycle>>(searchObject);

            dgvBicycleList.DataSource = list;
        }

        private void cbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            Helpers.SetComboBoxPlaceholderColor(cbBrand);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Helpers.SetComboBoxPlaceholderColor(cbCategory);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlDetails.Visible = true;
        }
    }
}
