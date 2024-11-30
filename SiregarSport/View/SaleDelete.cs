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
    public partial class SaleDelete : Form
    {
        Penjualan pjl = new Penjualan();
        public SaleDelete()
        {
            InitializeComponent();
            showSale();
            this.DoubleBuffered = true;
        }

        private void SaleDelete_Load(object sender, EventArgs e)
        {

        }
        public void showSale()
        {
            saleData.DataSource = pjl.showSale();
            saleData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        bool verify()
        {
            if (string.IsNullOrEmpty(txtIdSale.Text) || dateTimeTanggalSale.Value == null || string.IsNullOrEmpty(txtIdCustomer.Text) || string.IsNullOrEmpty(txtIdItem.Text) || string.IsNullOrEmpty(txtSum.Text))
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
                    pjl.deleteSale(txtIdSale.Text);
                    showSale();
                    ClearFields();
                    MessageBox.Show("Penjualan Deleted Suksess", "Delete Penjualan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdSale.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error - penjualan tidak terhapus", "Delete penjualan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PictureBoxClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            txtIdSale.Clear();
            dateTimeTanggalSale.Value = DateTime.Now;
            txtIdCustomer.Clear();
            txtIdItem.Clear();
            txtSum.Clear();
        }
        private void dateTimeTanggalSale_ValueChanged(object sender, EventArgs e)
        {
            dateTimeTanggalSale.CustomFormat = "dd/mm/yyyy";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            sale.Show();
            this.Hide();
        }

        private void saleData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtIdSale.Text = this.saleData.CurrentRow.Cells[0].Value?.ToString();
            dateTimeTanggalSale.Value = Convert.ToDateTime(this.saleData.CurrentRow.Cells[1].Value);
            txtIdCustomer.Text = this.saleData.CurrentRow.Cells[2].Value?.ToString();
            txtIdItem.Text = this.saleData.CurrentRow.Cells[3].Value?.ToString();
            txtSum.Text = this.saleData.CurrentRow.Cells[4].Value?.ToString();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            saleData.DataSource = pjl.Search(txtsearch.Text);
        }
    }
}
