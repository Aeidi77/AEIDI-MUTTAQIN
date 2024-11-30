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
    public partial class Reports : Form
    {
        Laporan lp = new Laporan();
        Admin admin = new Admin();
        public Reports()
        {
            InitializeComponent();
            showLaporan();
        }
        public void showLaporan()
        {
            dataRepotsPurchase.DataSource = lp.showLaporanPembelian();
            dataRepotsPurchase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataTotalPembelian.DataSource = lp.showTotalPembelian();
            dataTotalPembelian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataRepotsSale.DataSource = lp.showLaporanPenjualan();
            dataRepotsSale.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataTotalPenjualan.DataSource = lp.showTotalPenjualan();
            dataTotalPenjualan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void printDocumentLaporanPembelian_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(lblJudul.Text, new Font("Consolas", 36, FontStyle.Bold), Brushes.Black, new Point(250, 100));
            e.Graphics.DrawString(lblLaporanPembelian.Text, new Font("Consolas", 16, FontStyle.Bold), Brushes.Black, new Point(320, 160));
            int width = 100;
            int height = 100;
            Rectangle destinationRectangle = new Rectangle(150, 100, width, height);
            e.Graphics.DrawImage(pictureBoxLogo.Image, destinationRectangle);

            Laporan lp = new Laporan();
            DataTable dtLaporanPenjualan = lp.showLaporanPembelian();
            DataTable dtTotal = lp.showTotalPembelian();
            DataTable admin = lp.showAdmin();

            // Inisialisasi variabel untuk pengaturan cetak
            int rowPosition = 250;
            int colPosition = 100;
            Font font = new Font("Arial", 10, FontStyle.Regular);

            // Judul kolom
            e.Graphics.DrawString("ID ", font, Brushes.Black, colPosition, rowPosition);
            e.Graphics.DrawString("date Purchase", font, Brushes.Black, colPosition + 60, rowPosition);
            e.Graphics.DrawString("Name Distributor", font, Brushes.Black, colPosition + 170, rowPosition);
            e.Graphics.DrawString("Name Item", font, Brushes.Black, colPosition + 300, rowPosition);
            e.Graphics.DrawString("Brand", font, Brushes.Black, colPosition + 420, rowPosition);
            e.Graphics.DrawString("Price", font, Brushes.Black, colPosition + 480, rowPosition);
            e.Graphics.DrawString("Sum", font, Brushes.Black, colPosition + 540, rowPosition);
            e.Graphics.DrawString("Total", font, Brushes.Black, colPosition + 620, rowPosition);


            // Garis pemisah judul kolom dan data
            rowPosition += 30;
            e.Graphics.DrawLine(new Pen(Color.Black, 2), colPosition, rowPosition, colPosition + 660, rowPosition);

            // Data dari tabel
            foreach (DataRow row in dtLaporanPenjualan.Rows)
            {
                rowPosition += 30;
                e.Graphics.DrawString(row["id_purchase"].ToString(), font, Brushes.Black, colPosition, rowPosition);
                e.Graphics.DrawString(Convert.ToDateTime(row["date_purchase"]).ToShortDateString(), font, Brushes.Black, colPosition + 70, rowPosition);
                e.Graphics.DrawString(row["name_distributor"].ToString(), font, Brushes.Black, colPosition + 170, rowPosition);
                e.Graphics.DrawString(row["name_item"].ToString(), font, Brushes.Black, colPosition + 300, rowPosition);
                e.Graphics.DrawString(row["brand"].ToString(), font, Brushes.Black, colPosition + 430, rowPosition);
                e.Graphics.DrawString(row["price"].ToString(), font, Brushes.Black, colPosition + 480, rowPosition);
                e.Graphics.DrawString(row["sum"].ToString(), font, Brushes.Black, colPosition + 560, rowPosition);
                e.Graphics.DrawString(row["total"].ToString(), font, Brushes.Black, colPosition + 630, rowPosition);
            }

            e.Graphics.DrawString("Total Purchase   : ", font, Brushes.Black, colPosition + 450, rowPosition + 100);
            foreach (DataRow row in dtTotal.Rows)
            {
                e.Graphics.DrawString(row["total_purchase"].ToString(), font, Brushes.Black, colPosition + 580, rowPosition + 100);
            }

            string currentDate = DateTime.Now.ToString("dd MMMM yyyy");
            e.Graphics.DrawString("Bandung, " + currentDate, font, Brushes.Black, colPosition + 480, rowPosition + 360);

            // Menambahkan spasi
            e.Graphics.DrawString(" ", font, Brushes.Black, colPosition + 450, rowPosition + 100);
            e.Graphics.DrawString("TTD Admin ", font, Brushes.Black, colPosition + 540, rowPosition + 400);
        }

        private void btnPrintPembelian_Click(object sender, EventArgs e)
        {
         
            printPreviewLaporanPembelian.Document = printDocumentLaporanPembelian;
            printPreviewLaporanPembelian.ShowDialog();
        }

        private void printDocumentLaporanPenjualan_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(lblJudul.Text, new Font("Consolas", 36, FontStyle.Bold), Brushes.Black, new Point(250, 100));
            e.Graphics.DrawString(lblLaporanPenjualan.Text, new Font("Consolas", 16, FontStyle.Bold), Brushes.Black, new Point(320, 180));
            int width = 100;
            int height = 100;
            Rectangle destinationRectangle = new Rectangle(150, 100, width, height);
            e.Graphics.DrawImage(pictureBoxLogo.Image, destinationRectangle);

            Laporan lp = new Laporan();
            DataTable dtLaporanPenjualan = lp.showLaporanPenjualan();
            DataTable dtTotal = lp.showTotalPenjualan();
            DataTable admin = lp.showAdmin();

            // Inisialisasi variabel untuk pengaturan cetak
            int rowPosition = 250;
            int colPosition = 100;
            Font font = new Font("Arial", 10, FontStyle.Regular);

            // Judul kolom
            e.Graphics.DrawString("ID ", font, Brushes.Black, colPosition, rowPosition);
            e.Graphics.DrawString("date Sale", font, Brushes.Black, colPosition + 60, rowPosition);
            e.Graphics.DrawString("Name Customer", font, Brushes.Black, colPosition + 170, rowPosition);
            e.Graphics.DrawString("Name Item", font, Brushes.Black, colPosition + 300, rowPosition);
            e.Graphics.DrawString("Brand", font, Brushes.Black, colPosition + 420, rowPosition);
            e.Graphics.DrawString("Price", font, Brushes.Black, colPosition + 480, rowPosition);
            e.Graphics.DrawString("Sum", font, Brushes.Black, colPosition + 540, rowPosition);
            e.Graphics.DrawString("Total", font, Brushes.Black, colPosition + 620, rowPosition);


            // Garis pemisah judul kolom dan data
            rowPosition += 30;
            e.Graphics.DrawLine(new Pen(Color.Black, 2), colPosition, rowPosition, colPosition + 660, rowPosition);

            // Data dari tabel
            foreach (DataRow row in dtLaporanPenjualan.Rows)
            {
                rowPosition += 30;
                e.Graphics.DrawString(row["id_sale"].ToString(), font, Brushes.Black, colPosition, rowPosition);
                e.Graphics.DrawString(Convert.ToDateTime(row["date_sale"]).ToShortDateString(), font, Brushes.Black, colPosition + 70, rowPosition);
                e.Graphics.DrawString(row["name_customer"].ToString(), font, Brushes.Black, colPosition + 170, rowPosition);
                e.Graphics.DrawString(row["name_item"].ToString(), font, Brushes.Black, colPosition + 300, rowPosition);
                e.Graphics.DrawString(row["brand"].ToString(), font, Brushes.Black, colPosition + 430, rowPosition);
                e.Graphics.DrawString(row["price"].ToString(), font, Brushes.Black, colPosition + 480, rowPosition);
                e.Graphics.DrawString(row["sum"].ToString(), font, Brushes.Black, colPosition + 560, rowPosition);
                e.Graphics.DrawString(row["total"].ToString(), font, Brushes.Black, colPosition + 630, rowPosition);
            }

            e.Graphics.DrawString("Total Sale   : ", font, Brushes.Black, colPosition + 450, rowPosition + 100);
            foreach (DataRow row in dtTotal.Rows)
            {
                e.Graphics.DrawString(row["total_sales"].ToString(), font, Brushes.Black, colPosition + 580, rowPosition + 100);
            }

            string currentDate = DateTime.Now.ToString("dd MMMM yyyy");
            e.Graphics.DrawString("Bandung, " + currentDate, font, Brushes.Black, colPosition + 480, rowPosition + 360);

            // Menambahkan spasi
            e.Graphics.DrawString(" ", font, Brushes.Black, colPosition + 450, rowPosition + 100);
            e.Graphics.DrawString("TTD Admin ", font, Brushes.Black, colPosition + 540, rowPosition + 400);
        }

        private void btnPrintPenjualan_Click(object sender, EventArgs e)
        {
            
            printPreviewLaporanPenjualan.Document = printDocumentLaporanPenjualan;
            printPreviewLaporanPenjualan.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
