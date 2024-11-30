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
    public partial class CategoryUpdate : Form
    {
        Kategori ktg = new Kategori();
        public CategoryUpdate()
        {
            InitializeComponent();
            showCategory();
            this.DoubleBuffered = true;
        }

        private void CategoryUpdate_Load(object sender, EventArgs e)
        {

        }
        public void showCategory()
        {
            categoryData.DataSource = ktg.showCategory();
            categoryData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void PictureBoxUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ktg = new Kategori();
                ktg.updateCategory(txtIdCategory.Text, txtNameCategory.Text);

                MessageBox.Show("Update Success ");
                showCategory();
                ClearFields();
                txtIdCategory.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Update Eror " + ex.Message);
            }

        }

        private void PictureBoxClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            txtIdCategory.Clear();
            txtNameCategory.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            categoryData.DataSource = ktg.Search(txtSearch.Text);
        }

        private void categoryData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdCategory.Text = categoryData.CurrentRow.Cells[0].Value.ToString();
            txtNameCategory.Text = categoryData.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
