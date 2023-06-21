using MySql.Data.MySqlClient;
using ProjeBütSon.DOMAİN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeBütSon.DAL
{
    internal class kullaniciDAO
    {
        public void kullaniciKaydet(kullanici gKullanici)
        {
            (new MySqlCommand("insert into kullanicilar2 (kullaniciadi,kullanicisifre,kullanicigorevi) values ('" + gKullanici.Kadı + "' , '" + gKullanici.Sifre + "' , '" + gKullanici.Gorev + "')", (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }

        public void kullaniciGuncelle(kullanici gKullanici)
        {

            new MySqlCommand("update kullanicilar2 set kullaniciadi = '" + gKullanici.Kadı + "' , kullanicisifre = '" + gKullanici.Sifre + "' , kullanicigorevi = '" + gKullanici.Gorev + "'where id = '" + gKullanici.Id + "'", (new dbBaglanti()).baglantiGetir()).ExecuteNonQuery();
        }

        internal void kullaniciSil(kullanici gKullanici)
        {
            new MySqlCommand("delete from kullanicilar2 where id=" + gKullanici.Id, (new dbBaglanti()).baglantiGetir()).ExecuteNonQuery();
        }
    }
}
