using Guna.UI2.WinForms;
using SiregarSport.Controller;
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

namespace SiregarSport.View
{
    public partial class SignUp : Form
    {
        ValidasiInput validasiInput = new ValidasiInput();
        public SignUp()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            if (validasiInput.ValId(txtAdmin.Text) && validasiInput.valAdmin(txtIdAdmin.Text) && validasiInput.ValPassword(txtPasswoard.Text) && pictureBoxAdmin.Image != null)
            {
                try
                {
                    byte[] img = null;

                    if (pictureBoxAdmin.Image != null)
                    {
                        MemoryStream memori = new MemoryStream();
                        pictureBoxAdmin.Image.Save(memori, pictureBoxAdmin.Image.RawFormat);
                        img = memori.ToArray();
                    }

                    admin.tambahAdmin(txtAdmin.Text, txtIdAdmin.Text, txtPasswoard.Text, img);

                    MessageBox.Show("New Admin Added ", "Add Admin ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAdmin.Focus();
                    SignIn si = new SignIn();
                    si.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty field ", "eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            txtAdmin.MaxLength = 6;
            txtIdAdmin.MaxLength = 30;
            txtPasswoard.MaxLength = 10;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }

        private void btnInsertPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "select photo(*.jpg;*.png;*gif)|*.jpg;*.png;*.gif;";

            if (opf.ShowDialog() == DialogResult.OK)
            {
               pictureBoxAdmin .Image = Image.FromFile(opf.FileName);
            }
                
        }
    }
}
