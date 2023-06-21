using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeBütSon.DOMAİN
{
    internal class bolum
    {
        public bolum(int gİD,string gBolumad, string gBolumdekan)
        {
            this.Id = gİD;
            this.BolumAD = gBolumad;
            this.Bolumdekan = gBolumdekan;
        }
        public bolum(string gBolumad, string gBolumdekan)
        {
            this.BolumAD = gBolumad;
            this.Bolumdekan = gBolumdekan;
        }
        int id;
        string bolumAD;
        string bolumdekan;

        public int Id { get => id; set => id = value; }
        public string BolumAD { get => bolumAD; set => bolumAD = value; }
        public string Bolumdekan { get => bolumdekan; set => bolumdekan = value; }
    }
}
