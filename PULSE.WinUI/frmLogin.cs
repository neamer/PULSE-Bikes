using Flurl.Http;
using PULSE.Model.Requests;
using PULSE.WinUI.Helpers;
using PULSE.WinUI.Helpers.Helpers;
using PULSE.WinUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PULSE.WinUI
{
    public partial class frmLogin : Form
    {
        public bool ClickProcessed { get; set; } = true;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            DarkTitleBarClass.UseImmersiveDarkMode(Handle, true);
        }

        public void onLogout()
        {
            this.Show();
            tbUsername.Text = "";
            tbPassword.Text = "";
        }

        public void onClose()
        {
            Application.Exit();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if(ClickProcessed)
            {
                ClickProcessed = false;

                var username = tbUsername.Text;
                var password = tbPassword.Text;

                try
                {
                    var result = await $"{APIService._endpoint}staff/login".PostJsonAsync(new LoginRequest() { Username = username, Password = password }).ReceiveJson<Model.Staff>();

                    if (result != null)
                    {
                        APIService.Username = username;
                        APIService.Password = password;

                        var frm = new frmMain($"{result.FirstName} {result.LastName}", result.Role.Name, onLogout, onClose);
                        frm.Show();
                        ClickProcessed = true;
                        this.Hide();
                    }
                }
                catch (FlurlHttpException ex)
                {
                    var responseMsg = ex.Call.HttpResponseMessage.ReasonPhrase;
                    ClickProcessed = true;

                    MessageBox.Show(responseMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
