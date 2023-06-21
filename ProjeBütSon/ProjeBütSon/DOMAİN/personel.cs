using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeBütSon.DOMAİN
{
    internal class personel
    {
        public personel(int gİD, string gPersonelAD, string gPersonelTELNO, string gPersonelGOREV)
        {
            this.Id = gİD;
            this.personelAD = gPersonelAD;
            this.personelTELNO = gPersonelTELNO;
            this.PersonelGOREV = gPersonelGOREV;
        }
        public personel(string gPersonelAD, string gPersonelTELNO, string gPersonelGOREV)
        {
            this.personelAD = gPersonelAD;
            this.personelTELNO = gPersonelTELNO;
            this.PersonelGOREV = gPersonelGOREV;
        }
        int id;
        string personelAD;
        string personelTELNO;
        string personelGOREV;

        public int Id { get => id; set => id = value; }
        public string PersonelAD { get => personelAD; set => personelAD = value; }
        public string PersonelTELNO { get => personelTELNO; set => personelTELNO = value; }
        public string PersonelGOREV { get => personelGOREV; set => personelGOREV = value; }
    }
}
