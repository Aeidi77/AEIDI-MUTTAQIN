using Guna.UI2.WinForms.Enums;
using SiregarSport.Controller;
using SiregarSport.view;
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
using static SiregarSport.SignIn;

namespace SiregarSport.View
{
    public partial class Home : Form
    {
        private string LoggedIdUser;
        Admin admin = new Admin();

        public Home()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            lblHelloAdmin.Text = "@" + AppSession.LoggedInUser;
            
            byte[] photo = admin.GetAdminPhoto(AppSession.LoggedInUser);
            if (photo != null)
            {
                using (MemoryStream ms = new MemoryStream(photo))
                {
                    pictureBoxPhotoAdmin.Image = Image.FromStream(ms); // Tampilkan foto admin di Home
                }
            }
            else
            {
                pictureBoxPhotoAdmin.Image = null; // Jika foto tidak ditemukan
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
        //private void LoadAdminPhoto()
        //{
        //    // Ambil nama admin yang login dari session
        //    string adminName = AppSession.LoggedInUser;

        //    // Ambil foto admin dari database
        //    byte[] photo = admin.GetAdminPhoto(adminName);
        //    if (photo != null)
        //    {
        //        using (MemoryStream ms = new MemoryStream(photo))
        //        {
        //            pictureBoxPhotoAdmin.Image = Image.FromStream(ms); // Tampilkan foto admin di pictureBoxAdmin
        //        }
        //    }
        //    else
        //    {
        //        pictureBoxPhotoAdmin.Image = null; // Jika foto tidak ditemukan, kosongkan pictureBox
        //    }
        //}

        private void pictureBoxItems_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Show();
            this.Hide();
        }

        private void pictureBoxDistributor_Click(object sender, EventArgs e)
        {
            Distributor distributor = new Distributor();
            distributor.Show();
            this.Hide();
        }

        private void pictureBoxCustomers_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }

        private void pictureBoxPurchase_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            purchase.Show();
            this.Hide();
        }

        private void pictureBoxCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
            this.Hide();
        }

        private void pictureBoxSale_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            sale.Show();
            this.Hide();
        }

        private void pictureBoxLaporan_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
            this.Hide();
        }

        private void panelPhotoAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
            this.Hide();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }
    }
}
