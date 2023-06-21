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
    internal class personelDAO
    {
        public void PersonelKaydet(personel gPersonel)
        {
            (new MySqlCommand("insert into Personel_Tablo (personelAD,personelTELNO,personelGOREV) values ('" + gPersonel.PersonelAD + "' , '" + gPersonel.PersonelTELNO + "' , '" + gPersonel.PersonelGOREV + "')", (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }


        internal void PersonelSil(personel gPersonel)
        {
            new MySqlCommand("delete from Personel_Tablo where personelİD=" + gPersonel.Id, (new dbBaglanti()).baglantiGetir()).ExecuteNonQuery();
        }

        public void PersonelGuncelle(personel gPersonel)
        {
            new MySqlCommand("update Personel_Tablo set personelAD = '" + gPersonel.PersonelAD + "' , personelTELNO = '" + gPersonel.PersonelTELNO + "'where personelİD = '" + gPersonel.Id + "'", (new dbBaglanti()).baglantiGetir()).ExecuteNonQuery();
        }
    }
}
