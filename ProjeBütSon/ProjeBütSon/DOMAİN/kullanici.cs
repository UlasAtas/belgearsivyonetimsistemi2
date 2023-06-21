using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeBütSon.DOMAİN
{
    internal class kullanici
    {
        public kullanici(string gKadı, string gSifre, string gGorev)
        {
            this.Kadı = gKadı;
            this.Sifre = gSifre;
            this.Gorev = gGorev;
        }

        public kullanici(int gId, string gKadı, string gSifre, string gGorev) 
        {
            this.Id = gId ;
            this.Kadı = gKadı;
            this.Sifre = gSifre;
            this.Gorev = gGorev;
        }

        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        string kadı;

        public string Kadı
        {
            get { return kadı; }
            set { kadı = value; }
        }

        string sifre;

        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }

        string gorev;

        public string Gorev
        {
            get { return gorev; }
            set { gorev = value; }
        }
    }
}
