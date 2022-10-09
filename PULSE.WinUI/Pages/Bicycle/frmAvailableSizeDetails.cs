using PULSE.Model;
using PULSE.Model.Requests;
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
    public partial class frmAvailableSizeDetails : Form
    {
        public int ProductID { get; set; }
        public AvailableSize Model { get; set; }

        public APIService BicycleSizeService { get; set; } = new APIService("BicycleSize");
        public APIService AvailableSizeService { get; set; } = new APIService("AvailableSize");

        public delegate void AvailableSizeUpsertHandler();
        public event AvailableSizeUpsertHandler ModelSubmitted;

        public frmAvailableSizeDetails(int ProductID, AvailableSize model = null)
        {
            this.ProductID = ProductID;

            if (model != null)
            {
                Model = model;
            }

            InitializeComponent();
        }

        private void SelectModel()
        {
            var cbBicycleSizeItems = cbBicycleSize.Items.OfType<BicycleSize>().ToList();

            for (int i = 0; i < cbBicycleSizeItems.Count; i++)
            {
                if ((cbBicycleSizeItems[i] as BicycleSize).BicycleSizeId == Model.BicycleSizeId)
                {
                    cbBicycleSize.SelectedIndex = i;
                }
            }

            nudAvailableQty.Value = Model.AvailableQty ?? 0;
            cbBicycleSize.Enabled = false;
            lblTitle.Text = "Edit Available Size";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Submit();
        }

        private async void Submit()
        {
            var req = new AvailableSizeUpsertRequest()
            {
                ProductId = this.ProductID,
                BicycleSizeId = (cbBicycleSize.SelectedItem as BicycleSize).BicycleSizeId,
                AvailableQty = (int)nudAvailableQty.Value
            };


            if (Model == null)
            {
                var item = await AvailableSizeService.Post<AvailableSize>(req);

                if (item == null)
                {
                    return;
                }

                MessageBox.Show("Available Size Added Successfully!");
                ModelSubmitted.Invoke();
            }
            else
            {
                var item = await AvailableSizeService.PutComposite<AvailableSize>(req);

                if (item == null)
                {
                    return;
                }

                MessageBox.Show("Available Size Updated Successfully!");
                ModelSubmitted.Invoke();
            }
        }

        private void frmAvailableSizeDetails_Load(object sender, EventArgs e)
        {
            LoadSizes();
        }

        private async void LoadSizes()
        {
            var list = await BicycleSizeService.Get<List<BicycleSize>>();

            if (list == null)
            {
                return;
            }

            cbBicycleSize.DataSource = list;

            if (Model != null)
            {
                SelectModel();
            }
        }
    }
}
