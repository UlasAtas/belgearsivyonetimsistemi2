using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeBütSon.DOMAİN
{
    internal class muhasebe
    {
        public muhasebe(int gBelgeid, string gAlinanmal, string gAlinanfiyat, string gAlinanfirma)
        {
            this.Belgeid = gBelgeid;
            this.AlinanMAL = gAlinanmal;
            this.AlinanFİRMA = gAlinanfirma;
            this.AlinanFİYAT = gAlinanfiyat;
        }
        public muhasebe(string gAlinanmal,string gAlinanfiyat,string gAlinanfirma)
        {
            this.AlinanMAL = gAlinanmal;
            this.AlinanFİRMA = gAlinanfirma;
            this.AlinanFİYAT = gAlinanfiyat;
        }
        int belgeid;
        string alinanMAL;
        string alinanFİYAT;
        string alinanFİRMA;

        public int Belgeid { get => belgeid; set => belgeid = value; }
        public string AlinanMAL { get => alinanMAL; set => alinanMAL = value; }
        public string AlinanFİYAT { get => alinanFİYAT; set => alinanFİYAT = value; }
        public string AlinanFİRMA { get => alinanFİRMA; set => alinanFİRMA = value; }
    }
}
