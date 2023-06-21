using ProjeBütSon.DAL;
using ProjeBütSon.DOMAİN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjeBütSon.SERVİCE
{
    internal class kullaniciSERVİCE
    {
        internal void kullaniciKaydet(string gKullaniciad, string gKullanicisifre, string gKullanicigorev)
        {
            (new kullaniciDAO()).kullaniciKaydet(new kullanici(gKullaniciad, gKullanicisifre, gKullanicigorev));
        }

        internal void kullaniciGuncelle(int gId, string gKullaniciad, string gKullanicisifre, string gKullanicigorev)
        {
            (new kullaniciDAO()).kullaniciGuncelle(new kullanici(gId, gKullaniciad, gKullanicisifre, gKullanicigorev));
        }

        internal void kullaniciSil(int gId, string gKullaniciad, string gKullanicisifre, string gKullanicigorev)
        {
            (new kullaniciDAO()).kullaniciSil(new kullanici(gId, gKullaniciad, gKullanicisifre, gKullanicigorev));
        }
    }
}
