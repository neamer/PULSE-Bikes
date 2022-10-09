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

namespace PULSE.WinUI.Pages.Gear
{
    public partial class ucGearSelect : UserControl
    {
        public APIService GearService { get; set; } = new APIService("Gear");
        public APIService GearCategoryService { get; set; } = new APIService("GearCategory");
        public APIService BrandService { get; set; } = new APIService("Brand");

        public delegate void GearSelectHandler(Model.Gear item);
        public event GearSelectHandler GearSelected;

        public ucGearSelect()
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


            var categories = await GearCategoryService.Get<List<ProductCategory>>();
            cbCategory.Items.Add("Select a Category");
            ComboBoxHelpers.LoadComboBoxItems<ProductCategory>(cbCategory, categories);
        }



        private async void loadData()
        {
            var searchObject = new GearSearchObject()
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

            var list = await GearService.Get<List<Model.Gear>>(searchObject);

            if (list == null)
            {
                return;
            }

            dgvGearList.DataSource = list;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvGearList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvGearList.Rows[e.RowIndex].DataBoundItem as Model.Gear;

            GearSelected.Invoke(item);
            this.Hide();
        }
    }
}
