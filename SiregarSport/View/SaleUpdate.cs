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
    public partial class SaleUpdate : Form
    {
        Penjualan pjl = new Penjualan();
        public SaleUpdate()
        {
            InitializeComponent();
            showSale();
            this.DoubleBuffered = true;
        }

        private void SaleUpdate_Load(object sender, EventArgs e)
        {

        }
        public void showSale()
        {
            saleData.DataSource = pjl.showSale();
            saleData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PictureBoxUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                pjl.updateSale(txtIdSale.Text, dateTimeTanggalSale.Value, txtIdCustomer.Text, txtIdItem.Text, txtSum.Text);
                txtIdSale.Focus();
                MessageBox.Show("Update Success");
                showSale();
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            saleData.DataSource = pjl.Search(txtSearch.Text);
        }
    }
}
