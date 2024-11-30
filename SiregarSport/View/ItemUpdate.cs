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

    public partial class ItemUpdate : Form
    {
        Barang brg = new Barang();
        public ItemUpdate()
        {
            InitializeComponent();
            showItem();
            this.DoubleBuffered = true;
        }

        private void ItemUpdate_Load(object sender, EventArgs e)
        {

        }
        public void showItem()
        {
            itemData.DataSource = brg.showItem();
            itemData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void pictureBoxUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                brg = new Barang();
                brg.updateItem(txtIdItem.Text, txtNameItem.Text, txtIdCategory.Text, txtPrice.Text, txtBrand.Text, txtStock.Text);

                MessageBox.Show("Update Success");
                showItem();
                ClearFields();
                txtIdItem.Focus();
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
            txtIdItem.Clear();
            txtNameItem.Clear();
            txtIdCategory.Clear();
            txtBrand.Clear();
            txtPrice.Clear();
            txtStock.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            itemData.DataSource = brg.Search(txtSearch.Text);
        }

        private void itemData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtIdItem.Text = itemData.CurrentRow.Cells[0].Value.ToString();
            txtNameItem.Text = itemData.CurrentRow.Cells[1].Value.ToString();
            txtIdCategory.Text = itemData.CurrentRow.Cells[2].Value.ToString();
            txtPrice.Text = itemData.CurrentRow.Cells[3].Value.ToString();
            txtBrand.Text = itemData.CurrentRow.Cells[4].Value.ToString();
            txtStock.Text = itemData.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
