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
    public partial class DistributorUpdate : Form
    {
        Pemasok ps = new Pemasok();
        public DistributorUpdate()
        {
            InitializeComponent();
            showDistributor();
            this.DoubleBuffered = true;
        }
        public void showDistributor()
        {
            distributorData.DataSource = ps.showDistributor();
            distributorData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void DistributorUpdate_Load(object sender, EventArgs e)
        {

        }

        private void PictureBoxUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ps.updateDistributor(txtIdDistributor.Text, txtNameDistributor.Text, txtAddress.Text);
                MessageBox.Show("Update Success");
                showDistributor();
                ClearFields();
                txtIdDistributor.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Eror " + ex.Message);
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
