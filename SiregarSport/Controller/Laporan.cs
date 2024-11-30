using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiregarSport.Controller
{
    internal class Laporan : Model.Connection
    {
        public DataTable showLaporanPenjualan()
        {
            DataTable dt = new DataTable();

            try
            {
                string show = @"SELECT
                sale.id_sale,
                sale.date_sale,
                customer.name_customer,
                item.name_item,
                item.brand,
                sale.sum,
                item.price,
                sale.sum * item.price AS total
                FROM sale
                INNER JOIN customer ON sale.id_customer = customer.id_customer
                INNER JOIN item ON sale.id_item = item.id_item
                GROUP BY
                sale.id_sale,
                sale.date_sale,
                customer.name_customer,
                item.name_item,
                item.brand,
                sale.sum,
                item.price";

                da = new MySqlConnector.MySqlDataAdapter(show, GetConn());
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public DataTable showTotalPenjualan()
        {
            DataTable dt = new DataTable();

            try
            {
                string show = @"SELECT
                SUM(sale.sum * item.price) AS total_sales
                FROM sale
                INNER JOIN customer ON sale.id_customer = customer.id_customer
                INNER JOIN item ON sale.id_item = item.id_item";

                da = new MySqlConnector.MySqlDataAdapter(show, GetConn());
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public DataTable showAdmin()
        {
            DataTable dt = new DataTable();

            try
            {
                string tampil = "SELECT * FROM admin";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public DataTable showLaporanPembelian()
        {
            DataTable dt = new DataTable();

            try
            {
                string show = @"
                SELECT 
                p.id_purchase,
                p.date_purchase,
                d.name_distributor,
                i.name_item,
                i.brand,
                i.price,
                p.sum,
                p.sum * i.price AS total
                FROM 
                purchase p
                JOIN 
                distributor d ON p.id_distributor = d.id_distributor
                JOIN 
                item i ON p.id_item = i.id_item";

                da = new MySqlConnector.MySqlDataAdapter(show, GetConn());
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public DataTable showTotalPembelian()
        {
            DataTable dt = new DataTable();

            try
            {
                string show = @"SELECT
                SUM(purchase.sum * item.price) AS total_purchase
                FROM purchase
                INNER JOIN distributor ON purchase.id_distributor = distributor.id_distributor
                INNER JOIN item ON purchase.id_item = item.id_item";

                da = new MySqlConnector.MySqlDataAdapter(show, GetConn());
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

    }
}
