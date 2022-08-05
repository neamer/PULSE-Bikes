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
    public partial class ucBicycleSizeList : UserControl
    {
        public APIService BicycleSizeService { get; set; } = new APIService("BicycleSize");

        public ucBicycleSizeList()
        {
            InitializeComponent();

            dgvCategoryList.Columns[2].DefaultCellStyle.BackColor = Color.FromArgb(255, 95, 95, 111);
        }

        protected override void SetVisibleCore(bool value)
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

            base.SetVisibleCore(value);
        }

        protected override void OnLoad(EventArgs e)
        {
            ucBicycleSizeDetails1.ModelSubmitted += SubmitBicycleSize;

            base.OnLoad(e);
        }

        private void ClearData()
        {
            dgvCategoryList.DataSource = null;
        }

        private async void SubmitBicycleSize(BicycleSizeUpsertRequest data, int categoryID)
        {
            if (categoryID == -1)
            {
                await BicycleSizeService.Post<Model.BicycleSize>(data);
                MessageBox.Show("Bicycle Size Added Successfully!");
            }
            else
            {
                await BicycleSizeService.Put<Model.BicycleSize>(categoryID, data);
                MessageBox.Show("Bicycle Size Updated Successfully!");
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

            var list = await BicycleSizeService.Get<List<BicycleSize>>(searchObject);

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
            var item = dgvCategoryList.Rows[e.RowIndex].DataBoundItem as Model.BicycleSize;

            ucBicycleSizeDetails1.SelectCategory(item);
            pnlDetails.Visible = true;
        }
    }
}
