using ProjeBütSon.DAL;
using ProjeBütSon.DOMAİN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjeBütSon.SERVİCE
{
    internal class ogrenciSERVİCE
    {
        internal void OgrenciKaydetS(string gOgrenciAD, string gOgrencinumara)
        {
            (new ogrenciDAO()).OgrenciKaydet(new ogrenci(gOgrenciAD, gOgrencinumara));
        }

        internal void OgrenciSilS(int gİD, string gOgrenciAD, string gOgrencinumara)
        {
            (new ogrenciDAO()).OgrenciSil(new ogrenci(gİD, gOgrenciAD, gOgrencinumara));
        }

        internal void OgrenciGuncelleS(int gİD, string gOgrenciAD, string gOgrencinumara)
        {
            (new ogrenciDAO()).OgrenciGuncelle(new ogrenci(gİD, gOgrenciAD, gOgrencinumara));
        }
    }
}
