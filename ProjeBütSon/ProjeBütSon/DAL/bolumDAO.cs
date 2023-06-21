using ProjeBütSon.DOMAİN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjeBütSon.DAL
{
    internal class bolumDAO
    {
        public void BolumKaydet(bolum gBolum)
        {
            (new MySqlCommand("insert into Bolum_Tablo (bolumAD,bolumdekan) values ('" + gBolum.BolumAD + "' , '" + gBolum.Bolumdekan + "')", (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }


        internal void BolumSil(bolum gBolum)
        {
            new MySqlCommand("delete from Bolum_Tablo where id=" + gBolum.Id, (new dbBaglanti()).baglantiGetir()).ExecuteNonQuery();
        }

        public void BolumGuncelle(bolum gBolum)
        {
            new MySqlCommand("update Bolum_Tablo set bolumAD = '" + gBolum.BolumAD + "' , bolumdekan = '" + gBolum.Bolumdekan + "'where id = '" + gBolum.Id + "'", (new dbBaglanti()).baglantiGetir()).ExecuteNonQuery();
        }
    }
}
