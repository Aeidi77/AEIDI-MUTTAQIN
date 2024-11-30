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
    public partial class PurchaseAdd : Form
    {
        Pembelian pbl = new Pembelian();
        Pemasok ps = new Pemasok();
        Barang brg = new Barang();
        ValidasiInput validasiInput = new ValidasiInput();
        public PurchaseAdd()
        {
            InitializeComponent();
            showPurchase();
            this.DoubleBuffered = true;
        }

        private void PurchaseAdd_Load(object sender, EventArgs e)
        {
            txtIdPurchase.MaxLength = 6;
            txtSum.MaxLength = 8;
            LoadDistributor();
            LoadItem();

        }
        public void showPurchase()
        {
            purchaseData.DataSource = pbl.showPurchase();
            purchaseData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadDistributor()
        {
            DataTable distributor = ps.GetDistributor(); 

            if (distributor.Rows.Count > 0)
            {
                cbIdDistributor.DataSource = distributor;
                cbIdDistributor.ValueMember = "id_distributor";            
                cbIdDistributor.SelectedIndex = -1;             
            }
            else
            {
                MessageBox.Show("Id distributor tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LoadItem()
        {
            DataTable item = brg.GetItem();
            if(item.Rows.Count > 0)
            {
                cbIdItem.DataSource = item;
                cbIdItem.ValueMember = "id_item";
                cbIdItem.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Id item tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void PictureBoxAdd_Click(object sender, EventArgs e)
        {
            if (validasiInput.ValId(txtIdPurchase.Text) && cbIdDistributor.SelectedValue != null && cbIdItem.SelectedValue != null && validasiInput.ValStok(txtSum.Text))
            {
                try
                {
                    string selectedIdDistributor = cbIdDistributor.SelectedValue.ToString();
                    string selsectedIdItem = cbIdItem.SelectedValue.ToString();
                    pbl.addPurchase(txtIdPurchase.Text, datePurchase.Value, selectedIdDistributor,selsectedIdItem, txtSum.Text);
                    MessageBox.Show("New purchase Added ", "Add purchase ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    txtIdPurchase.Focus();
                    showPurchase();
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
            txtIdPurchase.Clear();
            cbIdDistributor.SelectedValue = -1;
            cbIdItem.SelectedValue = -1;
            txtSum.Clear();
            datePurchase.Value = DateTime.Now;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            purchase.Show();
            this.Hide();
        }

        private void datePurchase_ValueChanged(object sender, EventArgs e)
        {
            datePurchase.CustomFormat = "dd/mm/yyyy";
        }
    }
}
