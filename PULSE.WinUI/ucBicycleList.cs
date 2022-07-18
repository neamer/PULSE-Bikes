using Flurl.Http;
using PULSE.Model;
using PULSE.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PULSE.WinUI
{
    public partial class ucBicycleList : UserControl
    {
        public APIService BicycleService { get; set; } = new APIService("Bicycle");


        public ucBicycleList()
        {
            InitializeComponent();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        protected override void SetVisibleCore(bool value)
        {
            if(value)
            {
                loadData();
            }

            base.SetVisibleCore(value);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private async void loadData()
        {
            var searchObject = new BicycleSearchObject()
            {
                IncludeBrand = true,
                IncludeCategory = true
            };


            var list = await BicycleService.Get<List<Bicycle>>(searchObject);

            dgvBicycleList.DataSource = list;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
