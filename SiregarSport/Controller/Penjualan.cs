using MySqlConnector;
using SiregarSport.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiregarSport.Controller
{
    internal class Penjualan: Model.Connection
    {
        Connection connec = new Connection();
        public DataTable showSale()
        {
            DataTable dt = new DataTable();

            try
            {
                string tampil = " SELECT * FROM sale ";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public DataTable Search(string search)
        {
            DataTable table = new DataTable();
            try
            {
                using (MySqlConnection connection = connec.GetConn()) // Ensure proper disposal of resources
                {
                    string query = "SELECT * FROM sale WHERE CONCAT(id_sale, date_sale,id_customer,id_item,sum) LIKE @search";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@search", "%" + search + "%");
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(table);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message);
            }
            return table;
        }
        public void addSale(string idSale, DateTime dateSale, string idCustomer, string idItem, string sum)
        {
            string tambah = "insert into sale values(" + "@id_sale,@date_sale,@id_customer,@id_item,@sum)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_sale", MySqlConnector.MySqlDbType.VarChar).Value = idSale;
                cmd.Parameters.Add("@date_sale", MySqlConnector.MySqlDbType.DateTime).Value = dateSale;
                cmd.Parameters.Add("@id_customer", MySqlConnector.MySqlDbType.VarChar).Value = idCustomer;
                cmd.Parameters.Add("@id_item", MySqlConnector.MySqlDbType.VarChar).Value = idItem;
                cmd.Parameters.Add("@sum", MySqlConnector.MySqlDbType.VarChar).Value = sum;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror" + ex.Message);
            }

        }
        public void updateSale(string idSale, DateTime dateSale, string idCustomer, string idItem, string sum)
        {
            string update = "UPDATE Sale SET id_Sale=@id_Sale,date_Sale=@date_sale, id_customer=@id_customer, id_item=@id_item, sum=@sum WHERE id_sale=@id_sale";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(update, GetConn()))
                {
                    cmd.Parameters.Add("@id_sale", MySqlDbType.VarChar).Value = idSale;
                    cmd.Parameters.Add("@date_sale", MySqlDbType.DateTime).Value = dateSale;
                    cmd.Parameters.Add("@id_customer", MySqlDbType.VarChar).Value = idCustomer;
                    cmd.Parameters.Add("@id_item", MySqlDbType.VarChar).Value = idItem;
                    cmd.Parameters.Add("@sum", MySqlDbType.VarChar).Value = sum;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal: " + ex.Message);
            }
        }

        public void deleteSale(string idSale)
        {

            string delete = "DELETE FROM Sale WHERE id_sale = @id_sale";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(delete, GetConn()))
                {
                    cmd.Parameters.Add("@id_sale", MySqlDbType.VarChar).Value = idSale;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal delete: " + ex.Message);
            }


        }
    }
}
