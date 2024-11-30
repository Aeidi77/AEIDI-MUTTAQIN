using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SiregarSport.View
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            timerSplash.Start();
            

            // Tambahkan PictureBox
            PictureBox pictureBox = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.StretchImage, // Menjaga rasio aspek
                Dock = DockStyle.Fill,             // Mengisi seluruh form
                ImageLocation = @"C:\Users\Aeidi Muttaqin\source\repos\SiregarSport\SiregarSport\Resources\animasi.gif" // Path GIF
            };

            if (System.IO.File.Exists(pictureBox.ImageLocation))
            {
                this.Controls.Add(pictureBox); // Tambahkan PictureBox ke form
            }
            else
            {
                MessageBox.Show("File GIF tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Timer untuk menutup form splash
            Timer timer = new Timer
            {
                Interval = 15000 
            };
            timer.Tick += (s, e) =>
            {
                timer.Stop();
              
                
            };
            timer.Start();
        }
        int starP = 0;
        private void timerSplash_Tick(object sender, EventArgs e)
        {
            starP += 1;
            myProgres.Value = starP;
            persen.Text = starP + "%";
            if (myProgres.Value == 100)
            {
                myProgres.Value = 0;
                SignIn signIn = new SignIn();
                signIn.Show();
                this.Hide();
                timerSplash.Stop();

            }
        }
    }
}
