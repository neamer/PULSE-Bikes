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

namespace PULSE.WinUI.Pages.Part
{
    public partial class ucPartList : UserControl
    {
        public APIService PartService { get; set; } = new APIService("Part");
        public APIService PartCategoryService { get; set; } = new APIService("PartCategory");
        public APIService BrandService { get; set; } = new APIService("Brand");

        public ucPartList()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            ucPartDetails1.ModelSubmitted += SubmitPart;

            base.OnLoad(e);
        }

        protected override void SetVisibleCore(bool value)
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

            base.SetVisibleCore(value);
        }

        private void ClearData()
        {
            dgvPartList.DataSource = null;
            cbBrand.Items.Clear();
            cbCategory.Items.Clear();

            ucPartDetails1.ClearComboBoxes();
        }

        private async void LoadComboBoxes()
        {
            var brands = await BrandService.Get<List<Brand>>();
            cbBrand.Items.Add("Select Brand");
            ComboBoxHelpers.LoadComboBoxItems<Brand>(cbBrand, brands);


            var categories = await PartCategoryService.Get<List<ProductCategory>>();
            cbCategory.Items.Add("Select a Category");
            ComboBoxHelpers.LoadComboBoxItems<ProductCategory>(cbCategory, categories);

            ucPartDetails1.LoadComboBoxes(brands, categories);
        }



        private async void loadData()
        {
            var searchObject = new PartSearchObject()
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

            var list = await PartService.Get<List<Model.Part>>(searchObject);

            dgvPartList.DataSource = list;
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

        private async void SubmitPart(PartUpsertRequest data, int productId = -1)
        {
            if (productId == -1)
            {
                await PartService.Post<Model.Part>(data);
                MessageBox.Show("Part Added Successfully!");
            }
            else
            {
                await PartService.Put<Model.Part>(productId, data);
                MessageBox.Show("Part Updated Successfully!");
            }

            pnlDetails.Visible = false;
            loadData();
        }

        private void dgvPartList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvPartList.Rows[e.RowIndex].DataBoundItem as Model.Part;

            ucPartDetails1.SelectPart(item);
            pnlDetails.Visible = true;
        }
    }
}
