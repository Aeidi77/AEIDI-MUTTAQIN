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
    public partial class SaleAdd : Form
    {
        Penjualan pjl = new Penjualan();
        Pelanggan plg = new Pelanggan();
        Barang brg = new Barang();
        ValidasiInput validasiInput = new ValidasiInput();
        public SaleAdd()
        {
            InitializeComponent();
            showSale();
            this.DoubleBuffered = true;
        }
        private void LoadCustomer()
        {
            DataTable customer = plg.GetCustomer();

            if (customer.Rows.Count > 0)
            {
                cbIdCustomer.DataSource = customer;
                cbIdCustomer.ValueMember = "id_customer";
                cbIdCustomer.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Id customer tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LoadItem()
        {
            DataTable item = brg.GetItem();
            if (item.Rows.Count > 0)
            {
                cbIdItem.DataSource = item;
                cbIdItem.ValueMember = "id_item";
                cbIdItem.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Id item tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SaleAdd_Load(object sender, EventArgs e)
        {
            txtIdSale.MaxLength = 6;
            txtSum.MaxLength = 8;
            LoadCustomer();
            LoadItem();
        }
        public void showSale()
        {
            saleData.DataSource = pjl.showSale();
            saleData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PictureBoxAdd_Click(object sender, EventArgs e)
        {
            if (validasiInput.ValId(txtIdSale.Text) && validasiInput.ValId(txtIdCustomer.Text) && validasiInput.ValId(txtIdItem.Text) && validasiInput.ValStok(txtSum.Text))
            {
                try
                {
                    string selectedIdcustomer = cbIdCustomer.SelectedValue.ToString();
                    string selsectedIdItem = cbIdItem.SelectedValue.ToString();
                    pjl.addSale(txtIdSale.Text, dateTimeTanggalSale.Value, selectedIdcustomer, selsectedIdItem, txtSum.Text);
                    MessageBox.Show("New Sale Added ", "Add Penjualan ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    txtIdSale.Focus();
                    showSale();
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
            txtIdSale.Clear();
            dateTimeTanggalSale.Value = DateTime.Now;
            cbIdCustomer.SelectedValue = -1;
            cbIdItem.SelectedValue = -1;
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

        private void saleData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        
    }
}
