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
    internal class Pemasok: Model.Connection
    {
        Connection connec = new Connection();
        public DataTable showDistributor()
        {
            DataTable dt = new DataTable();

            try
            {
                string show = " SELECT * FROM distributor ";
                da = new MySqlConnector.MySqlDataAdapter(show, GetConn());
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public DataTable GetDistributor()
        {
            DataTable distributor = new DataTable();
            string query = "SELECT id_distributor FROM distributor"; // Sesuaikan dengan nama tabel dan kolom Anda

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, GetConn()))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(distributor);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil id distributor: " + ex.Message);
            }

            return distributor;
        }
       
        public void addDistributor(string idDistributor, string nameDistributor, string address)
        {
            string add = "insert into distributor values(" + "@id_distributor,@name_distributor,@address)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(add, GetConn());
                cmd.Parameters.Add("@id_distributor", MySqlConnector.MySqlDbType.VarChar).Value = idDistributor;
                cmd.Parameters.Add("@name_distributor", MySqlConnector.MySqlDbType.VarChar).Value = nameDistributor;
                cmd.Parameters.Add("@address", MySqlConnector.MySqlDbType.VarChar).Value = address;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror" + ex.Message);
            }

        }
        public DataTable Search(string search)
        {
            DataTable table = new DataTable();
            try
            {
                using (MySqlConnection connection = connec.GetConn()) // Ensure proper disposal of resources
                {
                    string query = "SELECT * FROM distributor WHERE CONCAT(id_distributor, name_distributor,address) LIKE @search";
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
        public void updateDistributor(string idDistributor, string nameDistributor, string address)
        {
            string update = "UPDATE distributor SET id_distributor=@id_distributor, name_distributor=@name_distributor,address=@address WHERE id_distributor = @id_distributor";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(update, GetConn()))
                {
                    cmd.Parameters.Add("@id_distributor", MySqlDbType.VarChar).Value = idDistributor;
                    cmd.Parameters.Add("@name_distributor", MySqlDbType.VarChar).Value = nameDistributor;
                    cmd.Parameters.Add("@address", MySqlConnector.MySqlDbType.VarChar).Value = address;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal: " + ex.Message);
            }


        }
        public void deleteDistributor(string idDistributor)
        {
            string delete = "DELETE FROM distributor WHERE id_distributor = @id_distributor";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(delete, GetConn()))
                {
                    cmd.Parameters.Add("@id_distributor", MySqlDbType.VarChar).Value = idDistributor;
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
