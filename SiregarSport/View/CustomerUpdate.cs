using SiregarSport.Controller;
using SiregarSport.view;
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
    public partial class CustomerUpdate : Form
    {
        Pelanggan plg = new Pelanggan();
   
        public CustomerUpdate()
        {
            InitializeComponent();
            showCustomer();
            this.DoubleBuffered = true;
        }

        private void CustomerUpdate_Load(object sender, EventArgs e)
        {

        }
        public void showCustomer()
        {
            customerData.DataSource = plg.showCustomer();
            customerData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PictureBoxUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                plg = new Pelanggan();
                plg.updateCustomer(txtIdCustomer.Text, txtNameCustomer.Text, txtAddress.Text);
                MessageBox.Show("Update Success");
                showCustomer();
                ClearFields();
                txtIdCustomer.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror" + ex.Message);
            }
        }

        private void PictureBoxClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtIdCustomer.Clear();
            txtNameCustomer.Clear();
            txtAddress.Clear();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            customerData.DataSource = plg.Search(txtSearch.Text);
        }

        private void customerData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtIdCustomer.Text = customerData.CurrentRow.Cells[0].Value.ToString();
            txtNameCustomer.Text = customerData.CurrentRow.Cells[1].Value.ToString();
            txtAddress.Text = customerData.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
