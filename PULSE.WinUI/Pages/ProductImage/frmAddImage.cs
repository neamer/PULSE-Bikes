using PULSE.Model;
using PULSE.Model.Requests;
using PULSE.WinUI.Helpers;

namespace PULSE.WinUI
{
    public partial class frmAddImage : Form
    {

        public APIService ProductImageService { get; set; } = new APIService("ProductImage");
        public int _productId;
        public Action onSuccess;

        public frmAddImage(int productId, Action onSuccess)
        {
            _productId = productId;
            InitializeComponent();
            btnSave.Enabled = false;
            this.onSuccess = onSuccess;
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image = Image.FromFile(openFileDialog1.FileName);
                btnSave.Enabled = true;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var req = new ProductImageUpsertRequest()
            {
                ProductId = _productId,
                Data = File.ReadAllBytes(openFileDialog1.FileName)
            };

            var response = await ProductImageService.Post<ProductImage>(req);
            
            if (response != null)
            {
                MessageBox.Show("Product image added succesfully!");
                onSuccess();
            }
        }
    }
}
