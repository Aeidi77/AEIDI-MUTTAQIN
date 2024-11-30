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
    public partial class CategoryDelete : Form
    {
        Kategori ktg = new Kategori();
        public CategoryDelete()
        {
            InitializeComponent();
            showCategory();
            this.DoubleBuffered = true;
        }

        private void CategoryDelete_Load(object sender, EventArgs e)
        {

        }
        public void showCategory()
        {
            categoryData.DataSource = ktg.showCategory();
            categoryData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        bool verify()
        {
            if (string.IsNullOrEmpty(txtIdCategory.Text) || string.IsNullOrEmpty(txtNameCategory.Text))
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
                    ktg.deleteCategory(txtIdCategory.Text);
                    showCategory();
                    ClearFields();

                    MessageBox.Show("kategori Deleted Suksess", "Delete kategori", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdCategory.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error - kategori tidak terhapus", "Delete kategori",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
