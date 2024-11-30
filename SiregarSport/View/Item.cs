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
    public partial class Item : Form
    {
    private Barang barang = new Barang();
        public Item()
        {
            InitializeComponent();
            showItem();
            this.DoubleBuffered = true;
        }

        private void Item_Load(object sender, EventArgs e)
        {

        }
        public void showItem()
        {
            itemData.DataSource = barang.showItem();
            itemData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            itemData.DataSource = barang.Search(txtSearch.Text);    
        }

        private void PictureBoxAdd_Click(object sender, EventArgs e)
        {
            ItemAdd itemadd = new ItemAdd();
            itemadd.Show();
            this.Hide();

        }

        private void PictureBoxUpdate_Click(object sender, EventArgs e)
        {
            ItemUpdate itemupdate = new ItemUpdate();
            itemupdate.Show();
            this.Hide();
        }

        private void PictureBoxDelete_Click(object sender, EventArgs e)
        {
            ItemDelete itemdelete = new ItemDelete();
            itemdelete.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void itemData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
