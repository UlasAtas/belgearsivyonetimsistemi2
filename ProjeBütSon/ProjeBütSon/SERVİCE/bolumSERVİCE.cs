using ProjeBütSon.DAL;
using ProjeBütSon.DOMAİN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeBütSon.SERVİCE
{
    internal class bolumSERVİCE
    {
        internal void BolumKaydetS(string gOgrenciAD, string gOgrencinumara)
        {
            (new bolumDAO()).BolumKaydet(new bolum(gOgrenciAD, gOgrencinumara));
        }

        internal void BolumSilS(int gİD, string gOgrenciAD, string gOgrencinumara)
        {
            (new bolumDAO()).BolumSil(new bolum(gİD, gOgrenciAD, gOgrencinumara));
        }

        internal void BolumGuncelleS(int gİD, string gOgrenciAD, string gOgrencinumara)
        {
            (new bolumDAO()).BolumGuncelle(new bolum(gİD, gOgrenciAD, gOgrencinumara));
        }
    }
}
