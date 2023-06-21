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
    internal class emanetlerDAO
    {
        public void EmanetKaydet(emanetler gEmanet)
        {
            (new MySqlCommand("insert into emanetci2 (evrakaciklama,emanetciad,emanetcisoyad,emanetcitelno,evrakid) values ('" + gEmanet.Evrakaciklama + "' , '" + gEmanet.Emanetciad + "' ,'"+gEmanet.Emanetcisoyad+ "' , '" + gEmanet.EmanetciTelno + "' , '" + gEmanet.Evrakid +"' )", (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }

        internal void EmanetKaydiSil(emanetler gEmanet)
        {
            new MySqlCommand("delete from emanetci2 where id=" + gEmanet.Id, (new dbBaglanti()).baglantiGetir()).ExecuteNonQuery();
        }
    }
}
