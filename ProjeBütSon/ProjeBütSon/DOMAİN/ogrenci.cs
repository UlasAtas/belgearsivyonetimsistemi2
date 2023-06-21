using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeBütSon.DOMAİN
{
    internal class ogrenci
    {
        public ogrenci(int gİD, string gOgrenciAD, string gOgrencinumara)
        {
            this.Id = gİD;
            this.Ogrenciadsoyad = gOgrenciAD;
            this.Ogrencinumara = gOgrencinumara;
        }
        public ogrenci(string gOgrenciAD, string gOgrencinumara)
        {
            this.Ogrenciadsoyad = gOgrenciAD;
            this.Ogrencinumara = gOgrencinumara;
        }
        int id;
        string ogrenciadsoyad;
        string ogrencinumara;

        public int Id { get => id; set => id = value; }
        public string Ogrenciadsoyad { get => ogrenciadsoyad; set => ogrenciadsoyad = value; }
        public string Ogrencinumara { get => ogrencinumara; set => ogrencinumara = value; }
    }
}
