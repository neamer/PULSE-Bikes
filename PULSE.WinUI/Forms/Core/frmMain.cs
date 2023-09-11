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
        public delegate void MainFormHandler();
        public event MainFormHandler onLogout;
        public event MainFormHandler onClose;

        public Size NavBtnMinSize { get; set; } = new Size() { Width = 230, Height = 40 };

        bool navBikesCollapsed = true;
        bool navGearCollapsed = true;
        bool navPartsCollapsed = true;

        UserControl _current;

        public string FullName { get; set; }
        public string Role { get; set; }

        public frmMain(string fullName, string role, MainFormHandler handleLogout, MainFormHandler handleClose)
        {
            InitializeComponent();

            this.FullName = fullName;
            this.Role = role;
            this.onLogout += handleLogout;
            this.onClose += handleClose;
        }

        private void btnNavBikes_Click(object sender, EventArgs e)
        {
            tmrNavBikes.Start();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            DarkTitleBarClass.UseImmersiveDarkMode(Handle, true);

            lblUsername.Text = FullName;
            lblRole.Text = Role;

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

            ucOrderList2.Hide();

            ucServicingList1.Hide();

            ucStaffList1.Hide();

            switch (Role)
            {
                case "Mechanic":
                    MechanicMode();
                    selectPage(ucServicingList1);
                    break;
                case "Salesperson":
                    SalespersonMode();
                    selectPage(ucOrderList2);
                    break;
                case "Storekeeper":
                    StorekeeperMode();
                    selectPage(ucBicycleList1);
                    break;
                default:
                    selectPage(ucBicycleList1);
                    break;
            }
        }

        public void MechanicMode()
        {
            pnlNavBikes.Size = new Size() { Height = 0, Width = 0 };
            pnlNavGear.Size = new Size() { Height = 0, Width = 0 };
            btnNavOrders.Size = new Size() { Height = 0, Width = 0 };
            btnNavStaff.Size = new Size() { Height = 0, Width = 0 };
        }

        public void SalespersonMode()
        {
            pnlNavBikes.Size = new Size() { Height = 0, Width = 0 };
            pnlNavGear.Size = new Size() { Height = 0, Width = 0 };
            pnlNavParts.Size = new Size() { Height = 0, Width = 0 };
            btnNavBrands.Size = new Size() { Height = 0, Width = 0 };
            btnNavServicing.Size = new Size() { Height = 0, Width = 0 };
            btnNavStaff.Size = new Size() { Height = 0, Width = 0 };
        }

        public void StorekeeperMode()
        {
            btnNavOrders.Size = new Size() { Height = 0, Width = 0 };
            btnNavServicing.Size = new Size() { Height = 0, Width = 0 };
            btnNavStaff.Size = new Size() { Height = 0, Width = 0 };
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
                if (pnl.Height <= NavBtnMinSize.Height)
                {
                    pnl.Height = NavBtnMinSize.Height;
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

        private void btnNavOrders_Click(object sender, EventArgs e)
        {
            selectPage(ucOrderList2);
        }

        private void btnNavServicing_Click(object sender, EventArgs e)
        {
            selectPage(ucServicingList1);
        }

        private void btnNavStaff_Click(object sender, EventArgs e)
        {
            selectPage(ucStaffList1);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logout", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                onLogout.Invoke();
                this.Close();
            }
        }

        private void frmMain_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            if(this.DialogResult == DialogResult.Cancel)
            {
                onClose.Invoke();
            }
        }

        #region ButtonPaint



        #endregion

        private void btnNavBikes_EnabledChanged(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            btn.ForeColor = btn.Enabled ? Color.White : Color.FromArgb(255, 109, 109, 109);
        }

        private void btnNavBikes_Paint(object sender, PaintEventArgs e)
        {
            var btn = (Button)sender;
            var drawBrush = new SolidBrush(btn.ForeColor);
            var sf = new StringFormat();
            btnNavBikes.Text = string.Empty;
            e.ClipRectangle.Offset(new Point() { X = 150, Y = 150 });
            e.Graphics.DrawString("BIKES", btn.Font, drawBrush, e.ClipRectangle);
            drawBrush.Dispose();
            sf.Dispose();
        }
    }
}
