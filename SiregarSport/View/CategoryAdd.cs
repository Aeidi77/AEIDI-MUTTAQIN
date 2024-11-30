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
    public partial class CategoryAdd : Form
    {
        Kategori ktg = new Kategori();
        ValidasiInput validasi = new ValidasiInput();
        public CategoryAdd()
        {
            InitializeComponent();
            showCategory();
            this.DoubleBuffered = true;
        }

        private void CategoryAdd_Load(object sender, EventArgs e)
        {
            txtIdCategory.MaxLength = 6;
            txtNameCategory.MaxLength = 255;
        }
        public void showCategory()
        {
            costumerData.DataSource = ktg.showCategory();
            costumerData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PictureBoxAdd_Click(object sender, EventArgs e)
        {
            ktg = new Kategori();

            if (validasi.ValId(txtIdCategory.Text) && validasi.valNama(txtNameCategory.Text))
            {
                try
                {
                    ktg.addCategory(txtIdCategory.Text, txtNameCategory.Text);
                    MessageBox.Show("New Kategori Added ", "Add Kategori ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    txtIdCategory.Focus();
                    showCategory();

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
            txtIdCategory.Clear();
            txtNameCategory.Clear();
        }

        private void dataKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdCategory.Text = costumerData.CurrentRow.Cells[0].Value.ToString();
            txtNameCategory.Text = costumerData.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
            this.Hide();
        }
    }
}
