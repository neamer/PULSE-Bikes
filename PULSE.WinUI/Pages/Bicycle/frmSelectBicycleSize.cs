using PULSE.Model;
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
    public partial class frmSelectBicycleSize : Form
    {
        public APIService AvailableSizeService { get; set; } = new APIService("AvailableSize");

        public Model.Bicycle bicycle { get; set; }
        public List<AvailableSize> Sizes { get; set; }

        public event BicycleSelectHandler AvailableSizeSelected;

        public frmSelectBicycleSize(Model.Bicycle item, List<AvailableSize> sizes)
        {
            bicycle = item;
            Sizes = sizes;

            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            foreach (var item in Sizes)
            {
                cbBicycleSize.Items.Add(item);
            }

            base.OnLoad(e);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                AvailableSizeSelected.Invoke(bicycle, cbBicycleSize.SelectedItem as AvailableSize);
                this.Close();
            }
        }

        private const int WM_CLOSE = 0x0010;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_CLOSE)
            {
                var autoValidate = this.AutoValidate;
                this.AutoValidate = AutoValidate.Disable;
                base.WndProc(ref m);
                this.AutoValidate = autoValidate;
            }
            else
                base.WndProc(ref m);
        }

        private void cbBicycleSize_Validating(object sender, CancelEventArgs e)
        {
            

            if (cbBicycleSize.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider.SetError(cbBicycleSize, "Select a size!");
            }
            else if ((cbBicycleSize.SelectedItem as AvailableSize)?.AvailableQty == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(cbBicycleSize, "The selected size is not available!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cbBicycleSize, "");
            }
        }
    }
}
