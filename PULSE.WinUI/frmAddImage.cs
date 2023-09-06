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
    public partial class frmAddImage : Form
    {
        public frmAddImage()
        {
            InitializeComponent();
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pbImage.Image = Image.FromFile(openFileDialog1.FileName);
        }
    }
}
