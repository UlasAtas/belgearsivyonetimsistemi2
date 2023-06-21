using ProjeBütSon.DAL;
using ProjeBütSon.DOMAİN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeBütSon.SERVİCE
{
    internal class emanetSERVİCE
    {
        internal void EmanetKaydetS(string gEvrakaciklama, string gEmanetciad,string gEmanetcisoyad,string gEmanetcitelno,string gEvrakid)
        {
            (new emanetlerDAO()).EmanetKaydet(new emanetler(gEvrakaciklama, gEmanetciad, gEmanetcisoyad, gEmanetcitelno,gEvrakid));
        }

        internal void EmanetSilS(int gid, string gEvrakaciklama, string gEmanetciad, string gEmanetcisoyad, string gEmanetcitelno, string gEvrakid)
        {
            (new emanetlerDAO()).EmanetKaydiSil(new emanetler(gid, gEvrakaciklama, gEmanetciad, gEmanetcisoyad, gEmanetcitelno, gEvrakid));
        }
    }
}
