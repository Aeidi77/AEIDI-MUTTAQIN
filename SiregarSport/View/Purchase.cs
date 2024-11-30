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
    public partial class Purchase : Form
    {
        Pembelian pbl = new Pembelian();
        public Purchase()
        {
            InitializeComponent();
            showPurchase();
            this.DoubleBuffered = true;
        }

        private void Purchase_Load(object sender, EventArgs e)
        {

        }
        public void showPurchase()
        {
            purchaseData.DataSource = pbl.showPurchase();
            purchaseData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PictureBoxAdd_Click(object sender, EventArgs e)
        {
            PurchaseAdd purchaseAdd = new PurchaseAdd();
            purchaseAdd.Show();
            this.Hide();
        }

        private void PictureBoxUpdate_Click(object sender, EventArgs e)
        {
            PurchaseUpdate purchaseUpdate = new PurchaseUpdate();
            purchaseUpdate.Show();
            this.Hide();
        }

        private void PictureBoxDelete_Click(object sender, EventArgs e)
        {
            PurchaseDelete purchaseDelete = new PurchaseDelete();
            purchaseDelete.Show();
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
            purchaseData.DataSource = pbl.Search(txtSearch.Text);
        }
    }
}
