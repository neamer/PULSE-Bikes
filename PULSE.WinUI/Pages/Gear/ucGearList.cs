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

namespace PULSE.WinUI.Pages.Gear
{
    public partial class ucGearList : UserControl
    {
        public APIService GearService { get; set; } = new APIService("Gear");
        public APIService GearCategoryService { get; set; } = new APIService("GearCategory");
        public APIService BrandService { get; set; } = new APIService("Brand");

        public ucGearList()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            ucGearDetails1.ModelSubmitted += SubmitGear;

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
            dgvGearList.DataSource = null;
            cbBrand.Items.Clear();
            cbCategory.Items.Clear();

            ucGearDetails1.ClearComboBoxes();
        }

        private async void LoadComboBoxes()
        {
            var brands = await BrandService.Get<List<Brand>>();
            cbBrand.Items.Add("Select Brand");
            ComboBoxHelpers.LoadComboBoxItems<Brand>(cbBrand, brands);


            var categories = await GearCategoryService.Get<List<ProductCategory>>();
            cbCategory.Items.Add("Select a Category");
            ComboBoxHelpers.LoadComboBoxItems<ProductCategory>(cbCategory, categories);

            ucGearDetails1.LoadComboBoxes(brands, categories);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlDetails.Visible = true;
        }

        private async void SubmitGear(GearUpsertRequest data, int productId = -1)
        {
            if (productId == -1)
            {
                var item = await GearService.Post<Model.Gear>(data);

                if (item == null)
                {
                    return;
                }

                MessageBox.Show("Gear Added Successfully!");
            }
            else
            {
                var item = await GearService.Put<Model.Gear>(productId, data);

                if (item == null)
                {
                    return;
                }

                MessageBox.Show("Gear Updated Successfully!");
            }

            pnlDetails.Visible = false;
            loadData();
        }

        private void dgvGearList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvGearList.Rows[e.RowIndex].DataBoundItem as Model.Gear;

            ucGearDetails1.SelectGear(item);
            pnlDetails.Visible = true;
        }
    }
}
