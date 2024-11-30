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
    internal class Kategori: Model.Connection
    {
        Connection connec = new Connection();
        public DataTable showCategory()
        {
            DataTable dt = new DataTable();

            try
            {
                string tampil = " SELECT * FROM category ";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public DataTable GetCategories()
        {
            DataTable categories = new DataTable();
            string query = "SELECT id_category FROM category"; // Sesuaikan dengan nama tabel dan kolom Anda

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, GetConn()))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(categories);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data kategori: " + ex.Message);
            }

            return categories;
        }
        public DataTable Search(string search)
        {
            DataTable table = new DataTable();
            try
            {
                using (MySqlConnection connection = connec.GetConn()) // Ensure proper disposal of resources
                {
                    string query = "SELECT * FROM category WHERE CONCAT(id_Category, name_Category) LIKE @search";
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
        public void addCategory(string idCategory, string nameCategory)
        {
            string tambah = "insert into category values(" + "@id_category,@name_category)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_category", MySqlConnector.MySqlDbType.VarChar).Value = idCategory;
                cmd.Parameters.Add("@name_category", MySqlConnector.MySqlDbType.VarChar).Value = nameCategory;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror" + ex.Message);
            }

        }
        public void updateCategory(string idCategory, string nameCategory)
        {
            string update = "UPDATE category SET id_category=@id_category, name_category=@name_category WHERE id_category = @id_category";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(update, GetConn()))
                {
                    cmd.Parameters.Add("@id_category", MySqlDbType.VarChar).Value = idCategory;
                    cmd.Parameters.Add("@name_category", MySqlDbType.VarChar).Value = nameCategory;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal: " + ex.Message);
            }


        }
        public void deleteCategory(string idCategory)
        {

            string delete = "DELETE FROM category WHERE id_category = @id_category";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(delete, GetConn()))
                {
                    cmd.Parameters.Add("@id_category", MySqlDbType.VarChar).Value = idCategory;
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
