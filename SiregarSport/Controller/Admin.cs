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
    internal class Admin: Model.Connection
    {
        Connection koneksi = new Connection();
        public DataTable getlist(MySqlCommand cmd)
        {
            cmd.Connection = koneksi.GetConn();
            DataTable dt = new DataTable();

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public void tambahAdmin(string id, string admin, string pass, byte[] photo)
        {
            string tambah = " INSERT INTO admin VALUES (" + "@id,@admin,@passwoard,@photo)";

            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@admin", MySqlConnector.MySqlDbType.VarChar).Value = admin;
                cmd.Parameters.Add("@passwoard", MySqlConnector.MySqlDbType.VarChar).Value = pass;
                cmd.Parameters.Add("@Photo", MySqlConnector.MySqlDbType.Blob).Value = photo;
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Data Gagal " + ex.Message);

            }
        }
        public byte[] GetAdminPhoto(string adminName)
        {
            // Buat perintah SQL
            MySqlCommand command = new MySqlCommand("SELECT photo FROM admin WHERE admin = @admin", GetConn());
            command.Parameters.Add("@admin", MySqlDbType.VarChar).Value = adminName;

            // Variabel untuk menyimpan hasil
            byte[] photo = null;

            try
            {
                // Periksa dan buka koneksi jika belum terbuka
                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }

                // Eksekusi perintah
                object result = command.ExecuteScalar();

                // Jika hasil tidak null, konversi ke byte array
                if (result != null && result != DBNull.Value)
                {
                    photo = (byte[])result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while fetching photo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Pastikan koneksi selalu ditutup
                if (command.Connection.State == ConnectionState.Open)
                {
                    command.Connection.Close();
                }
            }

            return photo;
        }




    }
}
    