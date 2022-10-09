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
    public partial class ucBicycleCategoryList : UserControl
    {
        public APIService BicycleCategoryService { get; set; } = new APIService("BicycleCategory");

        public ucBicycleCategoryList()
        {
            InitializeComponent();

            dgvCategoryList.Columns[2].DefaultCellStyle.BackColor = Color.FromArgb(255, 95, 95, 111);
        }

        protected override void SetVisibleCore(bool value)
        {
            if (EnvironmentHelper.IsInRuntimeMode(this))
            {
                if (value)
                {
                    pnlDetails.Visible = false;
                    LoadData();
                }
                else
                {
                    ClearData();
                }
            }

            base.SetVisibleCore(value);
        }

        protected override void OnLoad(EventArgs e)
        {
            ucBicycleCategoryDetails1.ModelSubmitted += SubmitBicycleCategory;

            base.OnLoad(e);
        }

        private void ClearData()
        {
            dgvCategoryList.DataSource = null;
        }

        private async void SubmitBicycleCategory(ProductCategoryUpsertRequest data, int categoryID)
        {
            if (categoryID == -1)
            {
                var item = await BicycleCategoryService.Post<Model.ProductCategory>(data);

                if (item == null)
                {
                    return;
                }

                MessageBox.Show("Bicycle Category Added Successfully!");
            }
            else
            {
                var item = await BicycleCategoryService.Put<Model.ProductCategory>(categoryID, data);

                if (item == null)
                {
                    return;
                }

                MessageBox.Show("Bicycle Category Updated Successfully!");
            }

            pnlDetails.Visible = false;
            LoadData();
        }

        private async void LoadData()
        {
            var searchObject = new NameGenericSearchObject() {
                Name = tbSearch.Text
            };

            var list = await BicycleCategoryService.Get<List<ProductCategory>>(searchObject);

            if (list == null)
            {
                return;
            }

            dgvCategoryList.DataSource = list;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlDetails.Visible = true;
        }

        private void dgvCategoryList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvCategoryList.Rows[e.RowIndex].DataBoundItem as Model.ProductCategory;

            ucBicycleCategoryDetails1.SelectCategory(item);
            pnlDetails.Visible = true;
        }

        private void pnlSearchWrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvCategoryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productCategoryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
