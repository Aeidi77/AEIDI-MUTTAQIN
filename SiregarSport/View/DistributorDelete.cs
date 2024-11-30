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
    public partial class DistributorDelete : Form
    {
        Pemasok ps = new Pemasok();
        public DistributorDelete()
        {
            InitializeComponent();
            showDistributor();
            this.DoubleBuffered = true;
        }

        private void DistributorDelete_Load(object sender, EventArgs e)
        {


        }
        public void showDistributor()
        {
            distributorData.DataSource = ps.showDistributor();
            distributorData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        bool verify()
        {
            if (string.IsNullOrEmpty(txtIdDistributor.Text) || string.IsNullOrEmpty(txtNameDistributor.Text) || string.IsNullOrEmpty(txtAddress.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void PictureBoxDelete_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                try
                {
                    ps = new Pemasok();
                    ps.deleteDistributor(txtIdDistributor.Text);
                    showDistributor();
                    ClearFields();
                    MessageBox.Show("Distributor Deleted Suksess", "Delete Distributor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdDistributor.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error - Distributor tidak terhapus", "Delete Pelanggan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            distributorData.DataSource = ps.Search(txtSearch.Text);
        }

        private void distributorData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtIdDistributor.Text = distributorData.CurrentRow.Cells[0].Value.ToString();
            txtNameDistributor.Text = distributorData.CurrentRow.Cells[1].Value.ToString();
            txtAddress.Text = distributorData.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
