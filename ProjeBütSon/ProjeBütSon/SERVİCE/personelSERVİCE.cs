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
    internal class personelSERVİCE
    {
        internal void PersonelKaydetS(string gPersonelAD, string gPersonelTELNO,string gPersonelGOREV)
        {
            (new personelDAO()).PersonelKaydet(new personel(gPersonelAD, gPersonelTELNO, gPersonelGOREV));
        }

        internal void PersonelSilS(int gİD,string gPersonelAD, string gPersonelTELNO, string gPersonelGOREV)
        {
            (new personelDAO()).PersonelSil(new personel(gİD,gPersonelAD, gPersonelTELNO, gPersonelGOREV));
        }

        internal void PersonelGuncelleS(int gİD, string gPersonelAD, string gPersonelTELNO, string gPersonelGOREV)
        {
            (new personelDAO()).PersonelGuncelle(new personel(gİD, gPersonelAD, gPersonelTELNO, gPersonelGOREV));
        }
    }
}
