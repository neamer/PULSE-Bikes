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

namespace PULSE.WinUI.Pages.Customer
{
    public partial class ucCustomerSelect : UserControl
    {
        public delegate void ModelSelected(Model.Customer item);
        public event ModelSelected SelectCustomer;

        public APIService CustomerService { get; set; } = new APIService("Customer");

        public ucCustomerSelect()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        protected override void SetVisibleCore(bool value)
        {
            if (EnvironmentHelper.IsInRuntimeMode(this))
            {
                if (value)
                {
                    LoadData();
                }
            }

            base.SetVisibleCore(value);
        }

        private async void LoadData()
        {
            var searchObject = new NameGenericSearchObject()
            {
                Name = tbSearch.Text,
            };

            var list = await CustomerService.Get<List<Model.Customer>>(searchObject);

            if (list == null)
            {
                return;
            }

            dgvCustomer.DataSource = list;
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvCustomer.Rows[e.RowIndex].DataBoundItem as Model.Customer;

            SelectCustomer.Invoke(item);
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
