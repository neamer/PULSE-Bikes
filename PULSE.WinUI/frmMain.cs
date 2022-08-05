using PULSE.WinUI.Helpers.Helpers;
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
    public partial class frmMain : Form
    {
        bool navBikesCollapsed = true;
        bool navGearCollapsed = true;
        bool navPartsCollapsed = true;

        UserControl _current;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnNavBikes_Click(object sender, EventArgs e)
        {
            tmrNavBikes.Start();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DarkTitleBarClass.UseImmersiveDarkMode(Handle, true);

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;

            ucBicycleList1.Hide();
            ucBicycleCategoryList1.Hide();
            ucBicycleSizeList1.Hide();

            ucGearList1.Hide();
            ucGearCategoryList1.Hide();

            ucPartList1.Hide();
            ucPartCategoryList1.Hide();

            ucBrandList1.Hide();

            selectPage(ucBicycleList1);
        }

        private void tmrNavBikes_Tick(object sender, EventArgs e)
        {
            navTimerTick(ref navBikesCollapsed, pnlNavBikes, tmrNavBikes);
        }

        private void tmrNavGear_Tick(object sender, EventArgs e)
        {
            navTimerTick(ref navGearCollapsed, pnlNavGear, tmrNavGear);
        }

        private void btnNavGear_Click(object sender, EventArgs e)
        {
            tmrNavGear.Start();
        }

        private void navTimerTick(ref bool collapsed, Panel pnl, System.Windows.Forms.Timer tmr)
        {
            // Returns true when the timer should stop
            if (collapsed)
            {
                pnl.Height += 10;
                if (pnl.Height == pnl.MaximumSize.Height)
                {
                    collapsed = false;
                    tmr.Stop();
                }
            }
            else
            {
                pnl.Height -= 10;
                if (pnl.Height == pnl.MinimumSize.Height)
                {
                    collapsed = true;
                    tmr.Stop();
                }
            }
        }

        private void selectPage(UserControl next)
        {
            if (_current != null)
            {
                _current.Hide();
            }
            next.Show();
            _current = next;
        }

        private void btnNavBikesSearch_Click(object sender, EventArgs e)
        {
            selectPage(ucBicycleList1);
        }

        private void btnNavGearSearch_Click(object sender, EventArgs e)
        {
            selectPage(ucGearList1);
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNavBikesCategories_Click(object sender, EventArgs e)
        {
            selectPage(ucBicycleCategoryList1);
        }

        private void btnNavParts_Click(object sender, EventArgs e)
        {
            tmrNavParts.Start();
        }

        private void tmrNavParts_Tick(object sender, EventArgs e)
        {
            navTimerTick(ref navPartsCollapsed, pnlNavParts, tmrNavParts);
        }

        private void btnNavPartsSearch_Click(object sender, EventArgs e)
        {
            selectPage(ucPartList1);
        }

        private void btnNavPartsCategories_Click(object sender, EventArgs e)
        {
            selectPage(ucPartCategoryList1);
        }

        private void btnNavGearCategories_Click(object sender, EventArgs e)
        {
            selectPage(ucGearCategoryList1);
        }

        private void btnNavBrands_Click(object sender, EventArgs e)
        {
            selectPage(ucBrandList1);
        }

        private void btnNavBikesSizes_Click(object sender, EventArgs e)
        {
            selectPage(ucBicycleSizeList1);
        }
    }
}
