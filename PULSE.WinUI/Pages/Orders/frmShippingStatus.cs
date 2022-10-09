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
    public partial class frmShippingStatus : Form
    {
        public Model.OrderHeader order;

        public delegate void StatusChangeHandler(frmShippingStatus frm);
        public event StatusChangeHandler StatusChange;

        public frmShippingStatus(Model.OrderHeader order)
        {
            InitializeComponent();
            this.order = order; 
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            StatusChange.Invoke(this);
        }

        private void frmShippingStatus_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        public void Refresh()
        {
            btnNext.Enabled = true;

            switch ((Model.OrderState)order.Status)
            {
                case Model.OrderState.Processed:
                    rbProcessed.Checked = true;
                    rbProcessed.Text = $"Processed at {order.TimeProcessed}";
                    break;

                case Model.OrderState.Packed:
                    rbProcessed.Checked = true;
                    rbProcessed.Text = $"Processed at {order.TimeProcessed}";

                    rbPacked.Checked = true;
                    rbPacked.Text = $"Packed at {order.TimePacked}";
                    break;

                case Model.OrderState.Shipped:
                    rbProcessed.Checked = true;
                    rbProcessed.Text = $"Processed at {order.TimeProcessed}";

                    rbPacked.Checked = true;
                    rbPacked.Text = $"Packed at {order.TimePacked}";

                    rbShipped.Checked = true;
                    rbShipped.Text = $"Shipped at {order.TimeShipped}";
                    break;

                case Model.OrderState.Delivered:
                    rbProcessed.Checked = true;
                    rbProcessed.Text = $"Processed at {order.TimeProcessed}";

                    rbPacked.Checked = true;
                    rbPacked.Text = $"Packed at {order.TimePacked}";

                    rbShipped.Checked = true;
                    rbShipped.Text = $"Shipped at {order.TimeShipped}";

                    rbDelivered.Checked = true;
                    rbDelivered.Text = $"Delivered at {order.TimeDelivered}";

                    btnNext.Enabled = false;
                    break;

                default:
                    Close();
                    break;
            }
        }
    }
}
