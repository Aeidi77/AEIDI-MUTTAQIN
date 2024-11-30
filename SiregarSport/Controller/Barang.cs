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
    internal class Barang: Model.Connection
    {
        Connection connec = new Connection();
        public DataTable showItem()
        {
            DataTable dt = new DataTable();

            try
            {
                string tampil = " SELECT * FROM item ";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public DataTable GetItem()
        {
            DataTable categories = new DataTable();
            string query = "SELECT id_item FROM item"; // Sesuaikan dengan nama tabel dan kolom Anda

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
        public void addItem(string idItem, string nameItem, string idCategory, string price, string brand, string stock)
        {
            string tambah = "insert into item values(" + "@id_item,@name_item,@id_category,@price,@brand,@stock)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id_item", MySqlConnector.MySqlDbType.VarChar).Value = idItem;
                cmd.Parameters.Add("@name_item", MySqlConnector.MySqlDbType.VarChar).Value = nameItem;
                cmd.Parameters.Add("@id_Category", MySqlConnector.MySqlDbType.VarChar).Value = idCategory;
                cmd.Parameters.Add("@price", MySqlConnector.MySqlDbType.VarChar).Value = price;
                cmd.Parameters.Add("@brand", MySqlConnector.MySqlDbType.VarChar).Value = brand;
                cmd.Parameters.Add("@stock", MySqlConnector.MySqlDbType.VarChar).Value = stock;
               
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
                MySqlConnection connection = connec.GetConn(); // Pastikan Anda memiliki objek koneksi yang benar
                string query = "SELECT * FROM item WHERE CONCAT(id_item, name_item, id_Category, Price, brand,stock) LIKE @search";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@search", "%" + search + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror search: " + ex.Message);
            }
            return table;
        }
        public void updateItem(string idItem, string nameItem, string idCategory, string price, string brand, string stock)
        {
            string update = "UPDATE item SET id_item=@id_item, name_Item=@name_item, id_Category=@id_Category, price=@price, brand=@brand, stock=@stock WHERE id_item = @id_item";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(update, GetConn()))
                {
                    cmd.Parameters.Add("@id_item", MySqlDbType.VarChar).Value = idItem;
                    cmd.Parameters.Add("@name_item", MySqlDbType.VarChar).Value = nameItem;
                    cmd.Parameters.Add("@id_Category", MySqlDbType.VarChar).Value = idCategory;
                    cmd.Parameters.Add("@price", MySqlDbType.VarChar).Value = price;
                    cmd.Parameters.Add("@brand", MySqlDbType.VarChar).Value = brand;
                    cmd.Parameters.Add("@stock", MySqlDbType.VarChar).Value = stock;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal: " + ex.Message);
            }


        }

        public void deleteItem(string idItem)
        {

            string delete = "DELETE FROM item WHERE id_item = @id_item";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(delete, GetConn()))
                {
                    cmd.Parameters.Add("@id_item", MySqlDbType.VarChar).Value = idItem;
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
