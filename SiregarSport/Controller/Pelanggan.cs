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
    internal class Pelanggan: Model.Connection
    {
        Connection connec = new Connection();
        public DataTable showCustomer()
        {
            DataTable dt = new DataTable();

            try
            {
                string show = " SELECT * FROM  customer";
                da = new MySqlConnector.MySqlDataAdapter(show, GetConn());
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public DataTable GetCustomer()
        {
            DataTable customer = new DataTable();
            string query = "SELECT id_customer FROM customer"; // Sesuaikan dengan nama tabel dan kolom Anda

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, GetConn()))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(customer);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil id customer: " + ex.Message);
            }

            return customer;
        }
        public DataTable Search(string search)
        {
            DataTable table = new DataTable();
            try
            {
                using (MySqlConnection connection = connec.GetConn()) // Ensure proper disposal of resources
                {
                    string query = "SELECT * FROM customer WHERE CONCAT(id_customer, name_customer,address) LIKE @search";
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
        public void addCustomer(string idCustomer, string nameCustomer, string address)
        {
            string add = "insert into customer values(" + "@id_customer,@name_Customer,@address)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(add, GetConn());
                cmd.Parameters.Add("@id_customer", MySqlConnector.MySqlDbType.VarChar).Value = idCustomer;
                cmd.Parameters.Add("@name_customer", MySqlConnector.MySqlDbType.VarChar).Value = nameCustomer;
                cmd.Parameters.Add("@address", MySqlConnector.MySqlDbType.VarChar).Value = address;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror" + ex.Message);
            }

        }
        public void updateCustomer(string idCustomer, string nameCustomer, string address)
        {
            string update = "UPDATE customer SET id_customer=@id_customer, name_customer=@name_customer,address=@address WHERE id_customer = @id_customer";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(update, GetConn()))
                {
                    cmd.Parameters.Add("@id_customer", MySqlDbType.VarChar).Value = idCustomer;
                    cmd.Parameters.Add("@name_customer", MySqlDbType.VarChar).Value = nameCustomer;
                    cmd.Parameters.Add("@address", MySqlConnector.MySqlDbType.VarChar).Value = address;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal: " + ex.Message);
            }


        }
        public void deleteCustomer(string idCustomer)
        {
            string delete = "DELETE FROM customer WHERE id_customer = @id_customer";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(delete, GetConn()))
                {
                    cmd.Parameters.Add("@id_customer", MySqlDbType.VarChar).Value = idCustomer;
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
