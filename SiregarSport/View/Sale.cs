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
    public partial class Sale : Form
    {
        Penjualan Penjualan = new Penjualan();
        public Sale()
        {
            InitializeComponent();
            showSale();
            this.DoubleBuffered = true;
        }

        private void Sale_Load(object sender, EventArgs e)
        {

        }
        public void showSale()
        {
            saleData.DataSource = Penjualan.showSale();
            saleData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PictureBoxAdd_Click(object sender, EventArgs e)
        {
            SaleAdd saleAdd = new SaleAdd();
            saleAdd.Show();
            this.Hide();
        }

        private void PictureBoxUpdate_Click(object sender, EventArgs e)
        {
            SaleUpdate saleUpdate = new SaleUpdate();
            saleUpdate.Show();
            this.Hide();
        }

        private void PictureBoxDelete_Click(object sender, EventArgs e)
        {
            SaleDelete saleDelete = new SaleDelete();
            saleDelete.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            saleData.DataSource = Penjualan.Search(txtSearch.Text);
        }
    }
}
