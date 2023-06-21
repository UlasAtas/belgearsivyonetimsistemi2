using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjeBütSon.DAL
{
    internal class dbBaglanti
    {
        public MySqlConnection baglantiGetir()
        {

            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3; Database=Grup7-2023; Uid=Grup7-2023; Pwd=NyP:974.cc");
            baglanti.Open();
            return baglanti;
        }
    }
}
