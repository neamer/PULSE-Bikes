using Flurl.Http;
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

namespace PULSE.WinUI
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
            LoadBrands();
            LoadCategories();

            base.OnLoad(e);
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
            if(value)
            {
                loadData();
            }

            base.SetVisibleCore(value);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private async void loadData()
        {
            var searchObject = new BicycleSearchObject()
            {
                IncludeBrand = true,
                IncludeCategory = true,
                AnyField = tbSearch.Text,
            };

            if(cbBrand.SelectedIndex != 0)
            {
                searchObject.BrandId = (cbBrand.SelectedItem as Brand).BrandId;
            }

            if (cbCategory.SelectedIndex != 0)
            {
                searchObject.ProductCategoryId = (cbCategory.SelectedItem as ProductCategory).ProductCategoryId;
            }

            var list = await BicycleService.Get<List<Bicycle>>(searchObject);

            dgvBicycleList.DataSource = list;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbBrand_SelectedValueChanged(object sender, EventArgs e)
        {
            Helpers.SetComboBoxPlaceholderColor(cbBrand);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Helpers.SetComboBoxPlaceholderColor(cbCategory);
        }
    }
}
