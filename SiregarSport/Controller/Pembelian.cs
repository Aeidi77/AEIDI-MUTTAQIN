using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;
using System.Windows.Forms;
using SiregarSport.Model;

namespace SiregarSport.Controller
{
    internal class Pembelian: Model.Connection
    {
    Connection connec = new Connection();
        public DataTable showPurchase()
        {
            DataTable dt = new DataTable();

            try
            {
                string tampil = " SELECT * FROM purchase ";
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
                    string query = "SELECT * FROM purchase WHERE CONCAT(id_purchase, date_purchase,id_distributor,id_item,sum) LIKE @search";
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
        public void addPurchase(string idPurchase, DateTime datePurchase, string idDistributor, string idItem, string sum)
        {
            string tambah = "insert into purchase values(" + "@id_purchase,@date_purchase,@id_distributor,@id_item,@sum)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_purchase", MySqlConnector.MySqlDbType.VarChar).Value = idPurchase;
                cmd.Parameters.Add("@date_purchase", MySqlConnector.MySqlDbType.DateTime).Value = datePurchase;
                cmd.Parameters.Add("@id_distributor", MySqlConnector.MySqlDbType.VarChar).Value = idDistributor;
                cmd.Parameters.Add("@id_item", MySqlConnector.MySqlDbType.VarChar).Value = idItem;
                cmd.Parameters.Add("@sum", MySqlConnector.MySqlDbType.VarChar).Value = sum;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror" + ex.Message);
            }

        }
        public void updatePurchase(string idPurchase, DateTime datePurchase, string idDistributor, string idItem, string sum)
        {
            string update = "UPDATE purchase SET id_purchase=@id_purchase,date_purchase=@date_purchase, id_distributor=@id_distributor, id_item=@id_item, sum=@sum WHERE id_purchase=@id_purchase";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(update, GetConn()))
                {
                    cmd.Parameters.Add("@id_purchase", MySqlDbType.VarChar).Value = idPurchase;
                    cmd.Parameters.Add("@date_purchase", MySqlDbType.DateTime).Value = datePurchase;
                    cmd.Parameters.Add("@id_distributor", MySqlDbType.VarChar).Value = idDistributor;
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

        public void deletePurchase(string idPurchase)
        {

            string delete = "DELETE FROM purchase WHERE id_purchase = @id_purchase";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(delete, GetConn()))
                {
                    cmd.Parameters.Add("@id_purchase", MySqlDbType.VarChar).Value = idPurchase;
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
