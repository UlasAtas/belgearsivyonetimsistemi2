using ProjeBütSon.DAL;
using ProjeBütSon.DOMAİN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeBütSon.SERVİCE
{
    internal class sinavSERVİCE
    {
        internal void SinavKaydetS(string gDersad, string gOgrencinumara, string gOgrenciad, string gOgrencinot)
        {
            (new sinavDAO()).SinavKaydet(new sinav(gDersad, gOgrencinumara, gOgrenciad, gOgrencinot));
        }

        internal void SinavSilS(int gBelgeid, string gDersad, string gOgrencinumara, string gOgrenciad, string gOgrencinot)
        {
            (new sinavDAO()).SinavSil(new sinav(gBelgeid, gDersad, gOgrencinumara, gOgrenciad, gOgrencinot));
        }

        internal void SinavGuncelleS(int gBelgeid, string gDersad, string gOgrencinumara, string gOgrenciad, string gOgrencinot)
        {
            (new sinavDAO()).SinavGuncelle(new sinav(gBelgeid, gDersad, gOgrencinumara, gOgrenciad, gOgrencinot));
        }
    }
}
