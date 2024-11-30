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
    public partial class PurchaseUpdate : Form
    {
        Pembelian pbl = new Pembelian();
        public PurchaseUpdate()
        {
            InitializeComponent();
            showPurchase();
            this.DoubleBuffered = true;
        }

        private void PurchaseUpdate_Load(object sender, EventArgs e)
        {

        }
        public void showPurchase()
        {
            purchaseData.DataSource = pbl.showPurchase();
            purchaseData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void PictureBoxUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                pbl.updatePurchase(txtIdPurchase.Text, datePurchase.Value, txtIdDistributor.Text, txtIdItem.Text, txtSum.Text);
                txtIdPurchase.Focus();
                MessageBox.Show("Update Success");
                showPurchase();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "eror", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void purchaseData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtIdPurchase.Text = this.purchaseData.CurrentRow.Cells[0].Value?.ToString();
            datePurchase.Value = Convert.ToDateTime(this.purchaseData.CurrentRow.Cells[1].Value);
            txtIdDistributor.Text = this.purchaseData.CurrentRow.Cells[2].Value?.ToString();
            txtIdItem.Text = this.purchaseData.CurrentRow.Cells[3].Value?.ToString();
            txtSum.Text = this.purchaseData.CurrentRow.Cells[4].Value?.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            purchaseData.DataSource = pbl.Search(txtSearch.Text);
        }
    }
}
