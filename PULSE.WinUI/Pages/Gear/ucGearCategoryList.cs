﻿using PULSE.Model;
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
    public partial class ucGearCategoryList : UserControl
    {
        public APIService GearCategoryService { get; set; } = new APIService("GearCategory");

        public ucGearCategoryList()
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
            ucGearCategoryDetails1.ModelSubmitted += SubmitGearCategory;

            base.OnLoad(e);
        }

        private void ClearData()
        {
            dgvCategoryList.DataSource = null;
        }

        private async void SubmitGearCategory(ProductCategoryUpsertRequest data, int categoryID)
        {
            if (categoryID == -1)
            {
                await GearCategoryService.Post<Model.ProductCategory>(data);
                MessageBox.Show("Gear Category Added Successfully!");
            }
            else
            {
                await GearCategoryService.Put<Model.ProductCategory>(categoryID, data);
                MessageBox.Show("Gear Category Updated Successfully!");
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

            var list = await GearCategoryService.Get<List<ProductCategory>>(searchObject);

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

            ucGearCategoryDetails1.SelectCategory(item);
            pnlDetails.Visible = true;
        }
    }
}