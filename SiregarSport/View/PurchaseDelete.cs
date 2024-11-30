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
    public partial class PurchaseDelete : Form
    {
        Pembelian pbl = new Pembelian();
        public PurchaseDelete()
        {
            InitializeComponent();
            showPurchase();
            this.DoubleBuffered = true;
            
        }
        public void showPurchase()
        {
            purchaseData.DataSource = pbl.showPurchase();
            purchaseData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        bool verify()
        {
                if (string.IsNullOrEmpty(txtIdPurchase.Text) || datePurchase.Value == null || string.IsNullOrEmpty(txtIdDistributor.Text) || string.IsNullOrEmpty(txtIdItem.Text) || string.IsNullOrEmpty(txtSum.Text))
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
                    pbl.deletePurchase(txtIdPurchase.Text);
                    showPurchase();
                    ClearFields();
                    MessageBox.Show("Purchase Deleted Suksess", "Delete Penjualan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdPurchase.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error - purchase tidak terhapus", "Delete purchase",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
        }

        private void PictureBoxClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            txtIdPurchase.Clear();
            txtIdDistributor.Clear();
            txtIdItem.Clear();
            txtSum.Clear();
            datePurchase.Value = DateTime.Now;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            purchase.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            purchaseData.DataSource = pbl.Search(txtSearch.Text);
        }

        private void purchaseData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtIdPurchase.Text = this.purchaseData.CurrentRow.Cells[0].Value?.ToString();
            datePurchase.Value = Convert.ToDateTime(this.purchaseData.CurrentRow.Cells[1].Value);
            txtIdDistributor.Text = this.purchaseData.CurrentRow.Cells[2].Value?.ToString();
            txtIdItem.Text = this.purchaseData.CurrentRow.Cells[3].Value?.ToString();
            txtSum.Text = this.purchaseData.CurrentRow.Cells[4].Value?.ToString();
        }
    }
}
