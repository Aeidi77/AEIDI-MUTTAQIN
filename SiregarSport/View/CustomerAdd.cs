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
    public partial class CustomerAdd : Form
    {
        Pelanggan plg = new Pelanggan();
        ValidasiInput validasiInput = new ValidasiInput();
        public CustomerAdd()
        {
            InitializeComponent();
            showCustomer();
            this.DoubleBuffered = true;
        }

        private void CustomerAdd_Load(object sender, EventArgs e)
        {
            txtIdCustomer.MaxLength = 6;
            txtNameCustomer.MaxLength = 50;
            txtAddress.MaxLength = 225;

        }
        public void showCustomer()
        {
            customerData.DataSource = plg.showCustomer();
            customerData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PictureBoxAdd_Click(object sender, EventArgs e)
        {
            if (validasiInput.ValId(txtIdCustomer.Text) && validasiInput.valNama(txtNameCustomer.Text) && validasiInput.ValAlamat(txtAddress.Text))
            {
                try
                {
                    plg.addCustomer(txtIdCustomer.Text, txtNameCustomer.Text, txtAddress.Text);
                    MessageBox.Show("New Pelanggan Added ", "Add Pelanggan ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    txtIdCustomer.Focus();
                    showCustomer();

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

        private void customerData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
