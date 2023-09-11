using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.Model.SearchObjects;
using PULSE.WinUI.Helpers;

namespace PULSE.WinUI.Pages.Brands
{
    public partial class ucBrandList : UserControl
    {
        public APIService BrandService { get; set; } = new APIService("Brand");

        public ucBrandList()
        {
            InitializeComponent();

            dgvBrandList.Columns[1].DefaultCellStyle.BackColor = Color.FromArgb(255, 95, 95, 111);
        }

        protected override void SetVisibleCore(bool value)
        {
            if (EnvironmentHelper.IsInRuntimeMode(this))
            {
                if (value)
                {
                    LoadData();
                    pnlDetails.Visible = false;
                }
                else
                {
                    ClearData();
                }
            }

            base.SetVisibleCore(value);
        }

        protected override void OnLoad(EventArgs e)
        {
            ucBrandDetails1.ModelSubmitted += SubmitBrandCategory;

            base.OnLoad(e);
        }

        private void ClearData()
        {
            dgvBrandList.DataSource = null;
        }

        private async void SubmitBrandCategory(BrandUpsertRequest data, int categoryID)
        {
            if (categoryID == -1)
            {
                var item = await BrandService.Post<Model.ProductCategory>(data);

                if (item == null)
                {
                    return;
                }

                MessageBox.Show("Brand Added Successfully!");
            }
            else
            {
                var item = await BrandService.Put<Model.ProductCategory>(categoryID, data);

                if (item == null)
                {
                    return;
                }

                MessageBox.Show("Brand Updated Successfully!");
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

            var list = await BrandService.Get<List<Brand>>(searchObject);

            if (list == null)
            {
                return;
            }

            dgvBrandList.DataSource = list;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlDetails.Visible = true;
        }

        private void dgvBrandList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvBrandList.Rows[e.RowIndex].DataBoundItem as Model.Brand;

            ucBrandDetails1.SelectBrand(item);
            pnlDetails.Visible = true;
        }

        private async void dgvBrandList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBrandList.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var item = dgvBrandList.Rows[e.RowIndex].DataBoundItem as Model.Brand;

                var response = await BrandService.Delete<Model.Brand>(item.Id);

                if (response != null)
                {
                    LoadData();
                }
            }
        }
    }
}
