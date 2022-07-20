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
    public partial class ucBicycleDetails : UserControl
    {
        public ucBicycleDetails()
        {
            InitializeComponent();
        }

        private void ucBicycleDetails_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            (Parent as Panel).Visible = false;
        }
    }
}
