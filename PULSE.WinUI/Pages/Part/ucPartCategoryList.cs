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
    public partial class ucPartCategoryList : UserControl
    {
        public APIService PartCategoryService { get; set; } = new APIService("PartCategory");

        public ucPartCategoryList()
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
                    LoadData();
                    pnlDetails.Visible = false;
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
            ucPartCategoryDetails1.ModelSubmitted += SubmitPartCategory;

            base.OnLoad(e);
        }

        private void ClearData()
        {
            dgvCategoryList.DataSource = null;
        }

        private async void SubmitPartCategory(ProductCategoryUpsertRequest data, int categoryID)
        {
            if (categoryID == -1)
            {
                var item = await PartCategoryService.Post<Model.Part>(data);

                if (item == null)
                {
                    return;
                }

                MessageBox.Show("Part Category Added Successfully!");
            }

            else
            {
                var item = await PartCategoryService.Put<Model.Part>(categoryID, data);

                if (item == null)
                {
                    return;
                }

                MessageBox.Show("Part Category Updated Successfully!");
            }

            pnlDetails.Visible = false;
            LoadData();
        }

        private async void LoadData()
        {
            var searchObject = new NameGenericSearchObject()
            {
                Name = tbSearch.Text
            };

            var list = await PartCategoryService.Get<List<ProductCategory>>(searchObject);

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

        private void dgvCategoryList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvCategoryList.Rows[e.RowIndex].DataBoundItem as Model.ProductCategory;

            ucPartCategoryDetails1.SelectCategory(item);
            pnlDetails.Visible = true;
        }
    }
}
