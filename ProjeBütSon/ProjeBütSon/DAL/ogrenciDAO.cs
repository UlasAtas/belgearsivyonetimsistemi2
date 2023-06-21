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
    internal class ogrenciDAO
    {
        public void OgrenciKaydet(ogrenci gOgrenci)
        {
            (new MySqlCommand("insert into OgrenciEvrak_Tablo (ogrenciAD,ogrencinumara) values ('" + gOgrenci.Ogrenciadsoyad + "' , '" + gOgrenci.Ogrencinumara + "')", (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }


        internal void OgrenciSil(ogrenci gOgrenci)
        {
            new MySqlCommand("delete from OgrenciEvrak_Tablo where id=" + gOgrenci.Id, (new dbBaglanti()).baglantiGetir()).ExecuteNonQuery();
        }

        public void OgrenciGuncelle(ogrenci gOgrenci)
        {
            new MySqlCommand("update OgrenciEvrak_Tablo set ogrenciAD = '" + gOgrenci.Ogrenciadsoyad+ "' , ogrenciNUMARA = '" + gOgrenci.Ogrencinumara + "'where id = '" +gOgrenci.Id +"'", (new dbBaglanti()).baglantiGetir()).ExecuteNonQuery();
        }
    }
}
