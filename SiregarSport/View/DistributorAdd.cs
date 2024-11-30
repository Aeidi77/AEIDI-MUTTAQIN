using SiregarSport.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiregarSport.View
{
    public partial class DistributorAdd : Form
    {
        Pemasok ps = new Pemasok();
        ValidasiInput validasiInput = new ValidasiInput();
        public DistributorAdd()
        {
            InitializeComponent();
            showDistributor();
            this.DoubleBuffered = true;
        }

        private void DistributorAdd_Load(object sender, EventArgs e)
        {
            txtIdDistributor.MaxLength = 6;
            txtNameDistributor.MaxLength = 100;
            txtAddress.MaxLength = 225;
        }
        public void showDistributor()
        {
            distributorData.DataSource = ps.showDistributor();
            distributorData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PictureBoxAdd_Click(object sender, EventArgs e)
        {
            if (validasiInput.ValId(txtIdDistributor.Text) && validasiInput.valNama(txtNameDistributor.Text) && validasiInput.ValAlamat(txtAddress.Text))
            {
                try
                {
                    ps.addDistributor(txtIdDistributor.Text, txtNameDistributor.Text, txtAddress.Text);
                    MessageBox.Show("New Distributor Added ", "Add Distributor ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    txtIdDistributor.Focus();
                    showDistributor();

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

        private void PictureBoxClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            txtIdDistributor.Clear();
            txtNameDistributor.Clear();
            txtAddress.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Distributor distributor = new Distributor();
            distributor.Show();
            this.Hide();
        }

        private void distributorData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
