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
    internal class muhasebeDAO
    {
        public void MuhasebeKaydet(muhasebe gMuhasebe)
        {
            (new MySqlCommand("insert into Muhasebe_Tablo (alinanMAL,alinanFİYAT,alinanFİRMA) values ('" + gMuhasebe.AlinanMAL + "' , '" + gMuhasebe.AlinanFİYAT + "' , '" + gMuhasebe.AlinanFİRMA + "')", (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }


        internal void MuhasebeSil(muhasebe gMuhasebe)
        {
            new MySqlCommand("delete from Muhasebe_Tablo where belgeid=" + gMuhasebe.Belgeid, (new dbBaglanti()).baglantiGetir()).ExecuteNonQuery();
        }

        public void MuhasebeGuncelle(muhasebe gMuhasebe)
        {
            new MySqlCommand("update Muhasebe_Tablo set alinanMAL = '" + gMuhasebe.AlinanMAL + "' , alinanFİYAT= '" + gMuhasebe.AlinanFİYAT + "' ,alinanFİRMA=  '" + gMuhasebe.AlinanFİRMA + "'where belgeid = '" + gMuhasebe.Belgeid + "'", (new dbBaglanti()).baglantiGetir()).ExecuteNonQuery();
        }
    }
}
