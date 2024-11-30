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
    public partial class Category : Form
    {
        Kategori ktg = new Kategori();
        public Category()
        {
            InitializeComponent();
            showkategori();
            this.DoubleBuffered = true;
        }

        private void Category_Load(object sender, EventArgs e)
        {

        }
        public void showkategori()
        {
            categoryData.DataSource = ktg.showCategory();
            categoryData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PictureBoxAdd_Click(object sender, EventArgs e)
        {
            CategoryAdd categoryAdd = new CategoryAdd();
            categoryAdd.Show();
            this.Hide();
        }

        private void PictureBoxUpdate_Click(object sender, EventArgs e)
        {
            CategoryUpdate categoryUpdate = new CategoryUpdate();
            categoryUpdate.Show();
            this.Hide();

        }

        private void PictureBoxDelete_Click(object sender, EventArgs e)
        {
            CategoryDelete categoryDelete = new CategoryDelete();
            categoryDelete.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            categoryData.DataSource = ktg.Search(txtSearch.Text);
        }
    }
}
