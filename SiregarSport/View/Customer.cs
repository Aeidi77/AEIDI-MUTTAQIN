using SiregarSport.Controller;
using SiregarSport.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiregarSport.view
{
    public partial class Customer : Form
    {
        Pelanggan plg = new Pelanggan();
        public Customer()
        {
            InitializeComponent();
            showCustomer();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        public void showCustomer()
        {
            customerData.DataSource = plg.showCustomer();
            customerData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void PictureBoxAdd_Click(object sender, EventArgs e)
        {
            CustomerAdd customerAdd = new CustomerAdd();
            customerAdd.Show();
            this.Hide();
        }

        private void PictureBoxUpdate_Click(object sender, EventArgs e)
        {
            CustomerUpdate customerUpdate = new CustomerUpdate();
            customerUpdate.Show();
            this.Hide();
        }

        private void PictureBoxDelete_Click(object sender, EventArgs e)
        {
            CustomerDelete customerDelete = new CustomerDelete();
            customerDelete.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            customerData.DataSource = plg.Search(txtSearch.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
