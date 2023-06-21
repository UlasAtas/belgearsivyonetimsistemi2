using ProjeBütSon.DAL;
using ProjeBütSon.DOMAİN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeBütSon.SERVİCE
{
    internal class muhasebeSERVİCE
    {
        internal void MuhasebeKaydetS(string gAlinanmal, string gAlinanfiyat, string gAlinanfirma)
        {
            (new muhasebeDAO()).MuhasebeKaydet(new muhasebe(gAlinanmal,gAlinanfiyat,gAlinanfirma));
        }

        internal void MuhasebeSilS(int gBelgeid, string gAlinanmal, string gAlinanfiyat, string gAlinanfirma)
        {
            (new muhasebeDAO()).MuhasebeSil(new muhasebe(gBelgeid,gAlinanmal, gAlinanfiyat, gAlinanfirma));
        }

        internal void MuhasebeGuncelleS(int gBelgeid, string gAlinanmal, string gAlinanfiyat, string gAlinanfirma)
        {
            (new muhasebeDAO()).MuhasebeGuncelle(new muhasebe(gBelgeid, gAlinanmal, gAlinanfiyat, gAlinanfirma));
        }
    }
}
