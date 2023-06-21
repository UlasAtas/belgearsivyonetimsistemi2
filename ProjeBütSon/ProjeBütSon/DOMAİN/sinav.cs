using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeBütSon.DOMAİN
{
    internal class sinav
    {
        public sinav(int gBelgeid,string gDersad, string gOgrencinumara, string gOgrenciad, string gOgrencinot)
        {
            this.Belgeid = gBelgeid;
            this.DersAD = gDersad;
            this.OgrenciNUMARA = gOgrencinumara;
            this.OgrenciAD = gOgrenciad;
            this.OgrenciNOT = gOgrencinot;
        }
        public sinav(string gDersad,string gOgrencinumara,string gOgrenciad,string gOgrencinot)
        {
            this.DersAD=gDersad;
            this.OgrenciNUMARA=gOgrencinumara;
            this.OgrenciAD = gOgrenciad;
            this.OgrenciNOT = gOgrencinot;
        }

        int belgeid;
        string dersAD;
        string ogrenciNUMARA;
        string ogrenciAD;
        string ogrenciNOT;

        public int Belgeid { get => belgeid; set => belgeid = value; }
        public string DersAD { get => dersAD; set => dersAD = value; }
        public string OgrenciNUMARA { get => ogrenciNUMARA; set => ogrenciNUMARA = value; }
        public string OgrenciAD { get => ogrenciAD; set => ogrenciAD = value; }
        public string OgrenciNOT { get => ogrenciNOT; set => ogrenciNOT = value; }
    }
}
