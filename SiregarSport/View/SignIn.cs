using MySqlConnector;
using SiregarSport.Controller;
using SiregarSport.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SiregarSport
{
    public partial class SignIn : Form
    {
        Admin admin = new Admin();
        HelloAdmin hd = new HelloAdmin();
        private int loginAttempts = 0;
        private DateTime lockoutEndTime;
        private Timer lockoutTimer;
        private static DateTime? globalLockoutEndTime = null; 
        private static bool isLockoutActive = false; 
        public SignIn()
        {
            InitializeComponent();
            txtPasswoard.PasswordChar = '*';
            this.DoubleBuffered = true;

            lockoutTimer = new Timer();
            lockoutTimer.Interval = 1000;
            lockoutTimer.Tick += LokoutTimer_Tick_1;
            lblLockoutTime.Visible = false;
            if (isLockoutActive && globalLockoutEndTime.HasValue)
            {
                lockoutEndTime = globalLockoutEndTime.Value;
                lockoutTimer.Start();
                btnSignIn.Enabled = false;
                lblLockoutTime.Visible = true;
            }

        }
        public static class AppSession
        {
            public static string LoggedInUser { get; private set; }

            public static void SetLoggedInUser(string username)
            {
                LoggedInUser = username;
            }
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtAdmin.Text) || string.IsNullOrEmpty(txtPasswoard.Text))
            {
                MessageBox.Show("Need login data", "Wrong login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = txtAdmin.Text;
            string pass = txtPasswoard.Text;
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM admin WHERE admin = @admin AND passwoard = @pass");
            cmd.Parameters.Add("@admin", MySqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;

            DataTable table = admin.getlist(cmd);

            if (table.Rows.Count > 0)
            {
                byte[] photo = admin.GetAdminPhoto(name);
                if (photo != null)
                {
                    using (MemoryStream ms = new MemoryStream(photo))
                    {
                        pictureBoxAdmin.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBoxAdmin.Image = null;
                }
                AppSession.SetLoggedInUser(name);

                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                loginAttempts++;

                if (loginAttempts >= 3)
                {
                    lockoutEndTime = DateTime.Now.AddMinutes(5); 
                    globalLockoutEndTime = lockoutEndTime;
                    isLockoutActive = true;
                    lockoutTimer.Start();
                    btnSignIn.Enabled = false;
                    lblLockoutTime.Visible = true;
                    MessageBox.Show("You have been locked out for 2 minutes due to multiple failed attempts.", "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Incorrect admin or password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void lblSignUp_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            su.Show();
            this.Hide();
        }

        private void pictureBoxBuka_Click_1(object sender, EventArgs e)
        {
            if (pictureBoxBuka.Visible == true)
            {

                pictureBoxBuka.Visible = false;
                pictureBoxTutup.Visible = true;
                txtPasswoard.PasswordChar = '*';

            }
        }
        private void pictureBoxTutup_Click_1(object sender, EventArgs e)
        {

            if (pictureBoxTutup.Visible == true)
            {

                pictureBoxTutup.Visible = false;
                pictureBoxBuka.Visible = true;
                txtPasswoard.PasswordChar = '\0';

            }
        }

        private void txtAdmin_TextChanged(object sender, EventArgs e)
        {
            string adminName = txtAdmin.Text.Trim();

            if (!string.IsNullOrEmpty(adminName))
            {
                byte[] photo = admin.GetAdminPhoto(adminName);

                if (photo != null)
                {
                    using (MemoryStream ms = new MemoryStream(photo))
                    {
                        pictureBoxAdmin.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBoxAdmin.Image = null;
                }
            }
            else
            {
                pictureBoxAdmin.Image = null;
            }
        }



        private void LokoutTimer_Tick_1(object sender, EventArgs e)
        {
            TimeSpan remainingTime = lockoutEndTime - DateTime.Now;

            if (remainingTime.TotalSeconds <= 0)
            {
                lockoutTimer.Stop();
                loginAttempts = 0;
                btnSignIn.Enabled = true;
                lblLockoutTime.Text = string.Empty;
                lblLockoutTime.Visible = false;

                globalLockoutEndTime = null;
                isLockoutActive = false;

            }
            else
            {
                lblLockoutTime.Text = $"Locked out for: {remainingTime.Minutes:D2}:{remainingTime.Seconds:D2}";
                lblLockoutTime.Visible = true;
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (lockoutTimer != null)
            {
                lockoutTimer.Stop();
                lockoutTimer.Dispose();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Exit or not", "exit confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            {

            }
            else
            {

                Application.Exit();
            }
        }
    }
}
