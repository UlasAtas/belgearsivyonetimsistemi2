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
    internal class sinavDAO
    {
        public void SinavKaydet(sinav gSinav)
        {
            (new MySqlCommand("insert into Sinav_Tablo (dersAD,ogrenciNUMARA,ogrenciAD,ogrenciNOT) values ('" + gSinav.DersAD + "' , '" + gSinav.OgrenciNUMARA + "' , '" + gSinav.OgrenciAD+ "' , '" + gSinav.OgrenciNOT+ "' )", (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }


        internal void SinavSil(sinav gSinav)
        {
            new MySqlCommand("delete from Sinav_Tablo where belgeid=" + gSinav.Belgeid, (new dbBaglanti()).baglantiGetir()).ExecuteNonQuery();
        }

        public void SinavGuncelle(sinav gSinav)
        {
            new MySqlCommand("update Sinav_Tablo set dersAD = '" + gSinav.DersAD + "' , ogrenciNUMARA = '" + gSinav.OgrenciNUMARA + "', ogrenciAD = '" + gSinav.OgrenciAD + "' , ogrenciNOT = '" + gSinav.OgrenciNOT + "' where belgeid = '" + gSinav.Belgeid + "'", (new dbBaglanti()).baglantiGetir()).ExecuteNonQuery();
        }
    }
}
