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
    public partial class ItemDelete : Form
    {
        Barang brg = new Barang();
        
        public ItemDelete()
        {
            InitializeComponent();
            showItem();
            this.DoubleBuffered = true; 
        }
        public void showItem()
        {
            itemData.DataSource = brg.showItem();
            itemData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        bool verify()
        {
            if (string.IsNullOrEmpty(txtIdItem.Text) || string.IsNullOrEmpty(txtNameItem.Text) || string.IsNullOrEmpty(txtIdCategory.Text) ||
                string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtBrand.Text) || string.IsNullOrEmpty(txtStock.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ItemDelete_Load(object sender, EventArgs e)
        {

        }

        private void PictureBoxDelete_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                try
                {
                    brg.deleteItem(txtIdItem.Text);
                    showItem();
                    ClearFields();

                    MessageBox.Show("Item Deleted Suksess", "Delete Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdItem.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error-Item tidak terhapus", "Delete Item",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
