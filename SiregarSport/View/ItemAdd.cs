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
using System.IO;

namespace SiregarSport.View
{
    public partial class ItemAdd : Form
    {
        Barang brg = new Barang();
        Kategori ktg = new Kategori();
        ValidasiInput validasiInput = new ValidasiInput();
        public ItemAdd()
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
        private void LoadCategories()
        {
            DataTable categories = ktg.GetCategories();

            if (categories.Rows.Count > 0)
            {
                cbCategory.DataSource = categories;
                cbCategory.ValueMember = "id_category";            
                cbCategory.SelectedIndex = -1;            
            }
            else
            {
                MessageBox.Show("Kategori tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void ItemAdd_Load(object sender, EventArgs e)
        {
            txtIdItem.MaxLength = 6;
            txtNameItem.MaxLength = 225;
            txtPrice.MaxLength = 8;
            txtStock.MaxLength = 6;
            LoadCategories();

        }

       
        private void PictureBoxAdd_Click(object sender, EventArgs e)
        {
            brg = new Barang();

            if (validasiInput.ValId(txtIdItem.Text) && validasiInput.valNama(txtNameItem.Text) && cbCategory.SelectedValue != null && validasiInput.Valharga(txtPrice.Text) && validasiInput.ValBrand(txtBrand.Text) && validasiInput.ValStok(txtStock.Text))
            {
                try
                {
                    string selectedCategoryId = cbCategory.SelectedValue.ToString();
                    brg.addItem(txtIdItem.Text, txtNameItem.Text, selectedCategoryId, txtPrice.Text, txtBrand.Text, txtStock.Text);

                    MessageBox.Show("New Item Added", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                    txtIdItem.Focus();
                    showItem();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PictureBoxClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }
        private void clearFields()
        {
            txtIdItem.Clear();
            txtNameItem.Clear();
            txtBrand.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            cbCategory.SelectedIndex = -1;

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Show();
            this.Hide();
        }

        private void itemData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
