using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.WinUI.Helpers;
using PULSE.WinUI.Pages.Bicycle;
using PULSE.WinUI.Pages.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PULSE.WinUI.Pages.Staff
{
    public partial class ucStaffList : UserControl
    {
        public APIService StaffService = new APIService("Staff");

        public ucStaffList()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            ucAddStaff1.onStaffInsert += StaffInsert;
            ucStaffUpdate1.onStaffUpdate += StaffUpdate;
            

            base.OnLoad(e);
        }

        protected override void SetVisibleCore(bool value)
        {
            if (EnvironmentHelper.IsInRuntimeMode(this))
            {
                if (value)
                {
                    LoadRoles();

                    ucAddStaff1.Hide();
                    ucStaffUpdate1.Hide();
                    LoadData();
                }
                else
                {
                    Reset();
                }
            }

            base.SetVisibleCore(value);
        }

        public async void LoadRoles()
        {
            var list = await StaffService.GetCustomPath<List<Model.Role>>("roles");

            cbRole.Items.Add("Select Role");
            Helpers.ComboBoxHelpers.LoadComboBoxItems(cbRole, list);
            cbStatus.SelectedIndex = 0;
            ucAddStaff1.LoadRoles(list);
        }

        public async void StaffInsert(StaffInsertRequest req)
        {
            var result = await StaffService.Post<Model.Staff>(req);

            if(result == null)
            {
                return;
            }

            LoadData();
            MessageBox.Show("Successfully added staff member!", "Success", MessageBoxButtons.OK);
        }

        public void Reset()
        {
            dgvStaffList.DataSource = null;

            cbRole.Items.Clear();
            ucAddStaff1.ResetRoles();
        }

        public async void StaffUpdate(int id, StaffUpdateRequest req)
        {
            var result = await StaffService.Put<Model.Staff>(id, req);

            if (result == null)
            {
                return;
            }


            LoadData();
            MessageBox.Show("Successfully updated staff member!", "Success", MessageBoxButtons.OK);
        }

        public async void StaffDelete(int id)
        {
            if (MessageBox.Show("Are you sure?", "Delete staff member", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var result = await StaffService.Delete<Model.Staff>(id);

                if (result == null)
                {
                    return;
                }

                LoadData();
                MessageBox.Show("Successfully deleted staff member!", "Success", MessageBoxButtons.OK);
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public async void LoadData()
        {
            var search = new StaffSearchObject()
            {
                AnyField = tbSearch.Text,
                IncludeRole = true,
            };

            if (cbRole.SelectedIndex != 0 && cbRole.SelectedIndex != -1)
            {
                search.RoleId = (cbRole.SelectedItem as Model.Role).RoleId;
            }

            if (cbStatus.SelectedIndex != 0 && cbStatus.SelectedIndex != -1)
            {
                search.Status = cbStatus.SelectedIndex == 1 ? true : false;
            }

            var results = await StaffService.Get<List<Model.Staff>>(search);

            if(results == null)
            {
                return;
            }

            foreach (var item in results)
            {
                item.CalcFullName();
                item.CalcStatusName();
            }

            dgvStaffList.DataSource = results;
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucAddStaff1.Show();
        }

        private void dgvStaffList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvStaffList.Rows[e.RowIndex].DataBoundItem as Model.Staff;

            ucStaffUpdate1.LoadEntity(item);
            ucStaffUpdate1.Show();
            ucStaffUpdate1.StaffId = item.StaffId;
        }

        private void dgvStaffList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                StaffDelete((dgvStaffList.Rows[e.RowIndex].DataBoundItem as Model.Staff).StaffId);
            }
        }
    }
}
