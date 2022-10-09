using PULSE.Model;
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
    public partial class ucBicycleSelect : UserControl
    {
        public APIService BicycleService { get; set; } = new APIService("Bicycle");
        public APIService BicycleCategoryService { get; set; } = new APIService("BicycleCategory");
        public APIService BrandService { get; set; } = new APIService("Brand");

        public event BicycleSelectHandler BicycleSelected;

        public ucBicycleSelect()
        {
            InitializeComponent();
        }

        protected override void SetVisibleCore(bool value)
        {
            if (EnvironmentHelper.IsInRuntimeMode(this))
            {
                if (value)
                {
                    LoadComboBoxes();

                    loadData();
                }
            }

            base.SetVisibleCore(value);
        }

        private async void LoadComboBoxes()
        {
            var brands = await BrandService.Get<List<Brand>>();
            cbBrand.Items.Add("Select Brand");
            ComboBoxHelpers.LoadComboBoxItems<Brand>(cbBrand, brands);


            var categories = await BicycleCategoryService.Get<List<ProductCategory>>();
            cbCategory.Items.Add("Select a Category");
            ComboBoxHelpers.LoadComboBoxItems<ProductCategory>(cbCategory, categories);
        }



        private async void loadData()
        {
            var searchObject = new BicycleSearchObject()
            {
                IncludeBrand = true,
                IncludeCategory = true,
                AnyField = tbSearch.Text,
            };

            if (cbBrand.SelectedIndex != 0 && cbBrand.SelectedIndex != -1)
            {
                searchObject.BrandId = (cbBrand.SelectedItem as Brand).BrandId;
            }

            if (cbCategory.SelectedIndex != 0 && cbCategory.SelectedIndex != -1)
            {
                searchObject.ProductCategoryId = (cbCategory.SelectedItem as ProductCategory).ProductCategoryId;
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

        private async void dgvBicycleList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvBicycleList.Rows[e.RowIndex].DataBoundItem as Model.Bicycle;

            var list = await BicycleService.GetCustomPath<List<AvailableSize>>($"Sizes/{item.ProductId}");

            if(list != null)
            {
                var frm = new frmSelectBicycleSize(item, list);
                frm.TopMost = true;
                frm.AvailableSizeSelected += AvailableSizeSelected;
                frm.Show();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void AvailableSizeSelected(Model.Bicycle item, AvailableSize size)
        {
            BicycleSelected.Invoke(item, size);
            this.Hide();
        }
    }
}
