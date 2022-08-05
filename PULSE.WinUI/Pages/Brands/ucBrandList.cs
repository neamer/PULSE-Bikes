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

namespace PULSE.WinUI.Pages.Brands
{
    public partial class ucBrandList : UserControl
    {
        public APIService BrandService { get; set; } = new APIService("Brand");

        public ucBrandList()
        {
            InitializeComponent();

            dgvBrandList.Columns[2].DefaultCellStyle.BackColor = Color.FromArgb(255, 95, 95, 111);
        }

        protected override void SetVisibleCore(bool value)
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

            base.SetVisibleCore(value);
        }

        protected override void OnLoad(EventArgs e)
        {
            ucBrandDetails1.ModelSubmitted += SubmitBrandCategory;

            base.OnLoad(e);
        }

        private void ClearData()
        {
            dgvBrandList.DataSource = null;
        }

        private async void SubmitBrandCategory(BrandUpsertRequest data, int categoryID)
        {
            if (categoryID == -1)
            {
                await BrandService.Post<Model.ProductCategory>(data);
                MessageBox.Show("BrandAdded Successfully!");
            }
            else
            {
                await BrandService.Put<Model.ProductCategory>(categoryID, data);
                MessageBox.Show("Brand Updated Successfully!");
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

            var list = await BrandService.Get<List<Brand>>(searchObject);

            dgvBrandList.DataSource = list;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlDetails.Visible = true;
        }

        private void dgvBrandList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvBrandList.Rows[e.RowIndex].DataBoundItem as Model.Brand;

            ucBrandDetails1.SelectBrand(item);
            pnlDetails.Visible = true;
        }
    }
}
