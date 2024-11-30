using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiregarSport.Controller
{
    internal class ValidasiInput
    {
        public bool valAdmin(string admin)
        {
            for (int a = 0; a < admin.Length; a++)
            {
                if (admin[a] >= '0' && admin[a] <= '9' || admin[0] == ' ' || admin[admin.Length - 1] == ' ' || admin[a] == ':' ||
                    admin[a] == ',' || admin[0] == '_' || admin[admin.Length - 1] == '_' || admin[a] == '/' || admin[a] == '\\' || admin[a] == '?' || admin[a] == '%' ||
                    admin[a] == '[' || admin[a] == ']' || admin[a] == '{' || admin[a] == '}' || admin[a] == '+' || admin[a] == '=' || admin[a] == '(' || admin[a] == ')' ||
                    admin[a] == '*' || admin[a] == '&' || admin[a] == '^' || admin[a] == '$' || admin[a] == '#' || admin[a] == '@' || admin[a] == '!' || admin[a] == '!')
                {
                    MessageBox.Show("Invalid Admin", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        public bool valNama(string nama)
        {
            for (int a = 0; a < nama.Length; a++)
            {
                if (nama[a] >= '0' && nama[a] <= '9' || nama[0] == ' ' || nama[nama.Length - 1] == ' ' || nama[a] == ':' ||
                    nama[a] == ',' || nama[0] == '_' || nama[nama.Length - 1] == '_' || nama[a] == '/' || nama[a] == '\\' || nama[a] == '?' || nama[a] == '%' ||
                    nama[a] == '[' || nama[a] == ']' || nama[a] == '{' || nama[a] == '}' || nama[a] == '+' || nama[a] == '=' || nama[a] == '(' || nama[a] == ')' ||
                    nama[a] == '*' || nama[a] == '&' || nama[a] == '^' || nama[a] == '$' || nama[a] == '#' || nama[a] == '@' || nama[a] == '!' || nama[a] == '!')
                {
                    MessageBox.Show("Invalid Admin", "Validation Eror", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        public bool ValAlamat(string alamat)
        {
            for (int i = 0; i < alamat.Length; i++)
            {
                char currentChar = alamat[i];

                if (!char.IsLetterOrDigit(currentChar) && currentChar != ' ' && currentChar != '-' && currentChar != '\'' &&
                    currentChar != ',' && currentChar != ':' && currentChar != '_' && currentChar != '/' && currentChar != '?')
                {
                    MessageBox.Show("Invalid Alamat", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            // Pastikan Alamat tidak dimulai atau diakhiri dengan spasi, tanda strip, garis bawah, atau tanda tanya.
            if (alamat[0] == ' ' || alamat[0] == '-' || alamat[0] == '_' || alamat[0] == '?' ||
                alamat[alamat.Length - 1] == ' ' || alamat[alamat.Length - 1] == '-' || alamat[alamat.Length - 1] == '_' || alamat[alamat.Length - 1] == '?')
            {
                MessageBox.Show("Invalid Alamat", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        public bool Valharga(string hrg)
        {
            // Harga dapat terdiri dari angka, tanda koma, dan tanda titik sebagai pemisah desimal.
            if (!string.IsNullOrWhiteSpace(hrg) && Regex.IsMatch(hrg, @"^[0-9]+(\.|,)?[0-9]*$"))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Harga ", "Validation Eror", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public bool ValId(string id)
        {
            // Periksa apakah ID kosong atau hanya berisi spasi
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("ID tidak boleh kosong atau hanya berisi spasi.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Periksa setiap karakter dalam ID
            for (int i = 0; i < id.Length; i++)
            {
                char currentChar = id[i];

                // Periksa apakah karakter adalah huruf atau angka
                if (!char.IsLetterOrDigit(currentChar))
                {
                    MessageBox.Show("ID hanya boleh berisi huruf atau angka.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            // Jika semua validasi berhasil
            return true;
        }

        public bool ValPassword(string password)
        {
            bool containsLetter = false;
            bool containsDigit = false;

            foreach (char character in password)
            {
                if (char.IsLetter(character))
                {
                    containsLetter = true;
                }
                else if (char.IsDigit(character))
                {
                    containsDigit = true;
                }

                // Berhenti jika sudah ditemukan setidaknya satu huruf dan satu angka
                if (containsLetter && containsDigit)
                {
                    break;
                }
            }

            // Periksa apakah password memenuhi syarat
            if (containsLetter && containsDigit)
            {

                return true;
            }
            else
            {
                MessageBox.Show("The password must contain at least one letter and one digit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public bool ValBrand(string brand)
        {
            // Periksa apakah input kosong
            if (string.IsNullOrWhiteSpace(brand))
            {
                MessageBox.Show("Brand name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Panjang brand harus berada di antara 3 hingga 30 karakter (sesuai kebutuhan)
            if (brand.Length < 3 || brand.Length > 30)
            {
                MessageBox.Show("Brand name must be between 3 and 30 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Brand tidak boleh mengandung angka atau karakter khusus
            if (!Regex.IsMatch(brand, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Brand name must contain only letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Brand tidak boleh diawali atau diakhiri dengan spasi
            if (brand[0] == ' ' || brand[brand.Length - 1] == ' ')
            {
                MessageBox.Show("Brand name cannot start or end with a space.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // Jika semua validasi lolos
        }

        public bool ValStok(string stock)
        {
            // Periksa apakah stok hanya mengandung angka
            if (int.TryParse(stock, out _))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Stock must contain only numeric digits.", " Validation Eror", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
