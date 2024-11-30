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
    public partial class CustomerDelete : Form
    {
        Pelanggan plg = new Pelanggan();
        public CustomerDelete()
        {
            InitializeComponent();
            showCustomer();
        }

        private void CustomerDelete_Load(object sender, EventArgs e)
        {

        }
        public void showCustomer()
        {
            customerData.DataSource = plg.showCustomer();
            customerData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        bool verify()
        {
            if (string.IsNullOrEmpty(txtIdCustomer.Text) || string.IsNullOrEmpty(txtNameCustomer.Text) || string.IsNullOrEmpty(txtAddress.Text))
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
                    plg = new Pelanggan();
                    plg.deleteCustomer(txtIdCustomer.Text);
                    showCustomer();
                    ClearFields();
                    MessageBox.Show("pelanggan Deleted Suksess", "Delete palanggan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdCustomer.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error ", "Delete Pelanggan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PictureBoxClear_Click(object sender, EventArgs e)
        {

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
