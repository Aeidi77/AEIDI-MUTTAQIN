using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiregarSport.Controller
{
    internal class HelloAdmin
    {
        public static class adminName
        {
            public static string namaAdmin { get; private set; }

            public static void SetLoggedInUser(string nama)
            {
                namaAdmin = nama;
            }
        }
    }
}
