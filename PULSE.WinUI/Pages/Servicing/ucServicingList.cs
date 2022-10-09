using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.WinUI.Helpers;
using PULSE.WinUI.Pages.Bicycle;
using PULSE.WinUI.Pages.Gear;
using PULSE.WinUI.Pages.Orders;
using PULSE.WinUI.Pages.Part;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PULSE.WinUI.Pages.Servicing
{
    public partial class ucServicingList : UserControl
    {
        public APIService ServicingService = new APIService("Servicing");

        public ucServicingList()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            ucCustomerSelect1.SelectCustomer += CustomerSelected;

            ucAddServicing1.OpenCustomerSelect += OpenCustomerSelect;
            ucAddServicing1.onRegister += RegisterServicing;
            ucServicingDetails1.Reload += loadData;
            ucServicingDetails1.OpenPartSelect += OpenPartSelect;
            ucPartSelect1.PartSelected += PartSelected;

            base.OnLoad(e);
        }

        private void OpenPartSelect()
        {
            ucPartSelect1.Show();
        }

        private void PartSelected(Model.Part part)
        {
            ucServicingDetails1.SelectPart(part);
        }

        protected override void SetVisibleCore(bool value)
        {
            if (EnvironmentHelper.IsInRuntimeMode(this))
            {
                if (value)
                {
                    loadData();

                    ucAddServicing1.Hide();
                    ucCustomerSelect1.Hide();
                    ucServicingDetails1.Hide();
                    ucPartSelect1.Hide();

                    cbState.Items.Add("Select State");
                    ComboBoxHelpers.LoadComboBoxItems<string>(cbState, Model.ServicingStateHelper.GetStateNames());
                }
                else
                {
                    Reset();
                }
            }

            base.SetVisibleCore(value);
        }

        private void Reset()
        {
            this.cbState.Items.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private async void loadData()
        {
            var searchObject = new ServicingSearchObject()
            {
                AnyField = tbSearch.Text,

                IncludeCustomer = true,
            };

            if (cbState.SelectedIndex != 0 && cbState.SelectedIndex != -1)
            {
                searchObject.Status = (int)Model.ServicingStateHelper.GetStateFromName(cbState.SelectedItem as string);
            }

            var list = await ServicingService.Get<List<Model.Servicing>>(searchObject);

            if (list == null)
            {
                return;
            }

            foreach (var item in list)
            {
                item.CalcStatusName();
            }

            dgvServicingList.DataSource = list;
        }

        public void OpenCustomerSelect()
        {
            ucCustomerSelect1.Show();
        }

        public void CustomerSelected(Model.Customer item)
        {
            ucAddServicing1.SelectCustomer(item);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucAddServicing1.Show();
        }

        private async void RegisterServicing(RegisterServicingRequest req)
        {
            var item = await ServicingService.Post<Model.Servicing>(req);

            if (item == null)
            {
                return;
            }

            MessageBox.Show($"Servicing {item.ServicingNumber} Added Successfully!");
            ucAddServicing1.Hide();
            ucAddServicing1.Reset();
            loadData();
        }

        private void dgvServicingList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvServicingList.Rows[e.RowIndex].DataBoundItem as Model.Servicing;

            ucServicingDetails1.Show();
            ucServicingDetails1.LoadDetails(item.ServicingId);
        }
    }
}
