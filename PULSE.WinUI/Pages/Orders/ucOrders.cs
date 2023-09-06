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

namespace PULSE.WinUI.Pages.Orders
{
    public partial class ucOrders : UserControl
    {
        public APIService OrderService { get; set; } = new APIService("Order");

        public bool SelectModeIsAdd { get; set; } = true;

        public ucOrders()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadData();
        }

        protected override void OnLoad(EventArgs e)
        {
            ucCustomerSelect1.SelectCustomer += CustomerSelected;
            ucBicycleSelect1.BicycleSelected += BicycleSelected;
            ucGearSelect1.GearSelected += GearSelected;
            ucPartSelect1.PartSelected += PartSelected;

            ucAddOrder1.OpenCustomerSelect += OpenCustomerSelect;
            ucAddOrder1.OpenBicycleSelect += OpenBicycleSelect;
            ucAddOrder1.OpenGearSelect += OpenGearSelect;
            ucAddOrder1.OpenPartSelect += OpenPartSelect;

            ucOrderDetails1.OpenBicycleSelect += OpenBicycleSelect;
            ucOrderDetails1.OpenGearSelect += OpenGearSelect;
            ucOrderDetails1.OpenPartSelect += OpenPartSelect;
            ucOrderDetails1.Reload += loadData;
            ucOrderDetails1.ReloadDetails += ReloadDetails;

            ucAddOrder1.OnSubmit += SubmitOrder;

            base.OnLoad(e);
        }

        public void BicycleSelected(Model.Bicycle item, Model.AvailableSize size)
        {
            if (SelectModeIsAdd)
            {
                ucAddOrder1.SelectBicycle(item, size);
            }
            else
            {
                ucOrderDetails1.AddBicycle(item, size);
            }
        }

        public void GearSelected(Model.Gear item)
        {
            if (SelectModeIsAdd)
            {
                ucAddOrder1.SelectGear(item);
            }
            else
            {
                ucOrderDetails1.SelectGear(item);
            }
        }

        public void PartSelected(Model.Part item)
        {
            if (SelectModeIsAdd)
            {
                ucAddOrder1.SelectPart(item);
            }
            else
            {
                ucOrderDetails1.SelectPart(item);
            }
        }

        protected override void SetVisibleCore(bool value)
        {
            if (value)
            {
                loadData();

                ucAddOrder1.Hide();
                ucCustomerSelect1.Hide();
                ucBicycleSelect1.Hide();
                ucGearSelect1.Hide();
                ucPartSelect1.Hide();
                ucOrderDetails1.Hide();

                cbState.Items.Add("Select State");
                ComboBoxHelpers.LoadComboBoxItems<string>(cbState, Model.OrderStateHelper.GetStateNames());
            }
            else
            {
                Reset();
            }

            base.SetVisibleCore(value);
        }

        private void Reset()
        {
            cbState.Items.Clear();
        }

        public async void loadData()
        {
            var searchObject = new OrderSearchObject()
            {
                IncludeDetails = true,
                IncludeCustomer = true,
                IncludePayment = false,
                AnyField = tbSearch.Text,
            };

            if (cbState.SelectedIndex != 0 && cbState.SelectedIndex != -1)
            {
                searchObject.Status = (int)Model.OrderStateHelper.GetStateFromName(cbState.SelectedItem as string);
            }

            var list = await OrderService.Get<List<Model.OrderHeader>>(searchObject);

            if (list == null)
            {
                return;
            }

            foreach (var item in list)
            {
                item.CalcNoOfItems();
                item.CalcTotal();
                item.CalcStatusName();
            }

            dgvOrderList.DataSource = list;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucAddOrder1.Show();
            SelectModeIsAdd = true;
        }

        public void OpenCustomerSelect()
        {
            ucCustomerSelect1.Show();
        }

        public void OpenBicycleSelect()
        {
            ucBicycleSelect1.Show();
        }

        public void OpenGearSelect()
        {
            ucGearSelect1.Show();
        }

        public void OpenPartSelect()
        {
            ucPartSelect1.Show();
        }

        public void CustomerSelected(Model.Customer item)
        {
            ucAddOrder1.SelectCustomer(item);
        }

        public async void ReloadDetails()
        {
            var details = await OrderService.GetById<Model.OrderHeader>(ucOrderDetails1.OrderID);
            ucOrderDetails1.LoadOrder(details);
        }

        public async void SubmitOrder(OrderHeaderInsertRequest req)
        {
            var item = await OrderService.Post<Model.OrderHeader>(req);

            if (item == null)
            {
                return;
            }

            MessageBox.Show($"Order {item.OrderNumber} Added Successfully!");
            ucAddOrder1.Hide();
            ucAddOrder1.Reset();
            loadData();
        }


        private void dgvOrderList_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvOrderList.Rows[e.RowIndex].DataBoundItem as Model.OrderHeader;

            ucOrderDetails1.OrderID = item.Id;
            ReloadDetails();
            ucOrderDetails1.Show();
            SelectModeIsAdd = false;
        }
    }
}
