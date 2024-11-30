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
    public partial class Distributor : Form
    {
        private Pemasok Pemasok = new Pemasok();
        public Distributor()
        {
            InitializeComponent();
            showDistributor();
            this.DoubleBuffered = true;
        }

        private void Distributor_Load(object sender, EventArgs e)
        {

        }
        public void showDistributor()
        {
           distributorData.DataSource = Pemasok.showDistributor();
           distributorData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PictureBoxAdd_Click(object sender, EventArgs e)
        {
            DistributorAdd distributorAdd = new DistributorAdd();
            distributorAdd.Show();
            this.Hide();
        }

        private void PictureBoxUpdate_Click(object sender, EventArgs e)
        {
            DistributorUpdate distributorUpdate = new DistributorUpdate();
            distributorUpdate.Show();
            this.Hide();
        }

        private void PictureBoxDelete_Click(object sender, EventArgs e)
        {
            DistributorDelete distributorDelete = new DistributorDelete();
            distributorDelete.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            distributorData.DataSource = Pemasok.Search(txtSearch.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void distributorData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
