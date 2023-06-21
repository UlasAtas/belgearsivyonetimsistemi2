using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeBütSon.DOMAİN
{
    internal class emanetler
    {
        public emanetler(string gEvrakaciklama, string gEmanetciad, string gEmanetcisoyad,string gEmanetcitelno, string gEvrakid)
        {   
            this.Evrakaciklama = gEvrakaciklama;
            this.Emanetciad = gEmanetciad;  
             this.Emanetcisoyad= gEmanetcisoyad;
            this.EmanetciTelno = gEmanetcitelno;
            this.Evrakid = gEvrakid;
        }
        public emanetler(int gİD, string gEvrakaciklama, string gEmanetciad, string gEmanetcisoyad,string gEmanetcitelno,string gEvrakid)
        {
            this.Id = gİD;
            this.Evrakaciklama = gEvrakaciklama;
            this.Emanetciad = gEmanetciad;
            this.Emanetcisoyad = gEmanetcisoyad;
            this.EmanetciTelno = gEmanetcitelno;
            this.Evrakid = gEvrakid;
            
        }
        int id;
        string evrakaciklama;
        string emanetciad;
        string emanetcisoyad;
        string emanetciTelno;
        string evrakid;

        public int Id { get => id; set => id = value; }
        public string Emanetciad { get => emanetciad; set => emanetciad = value; }
        
        public string EmanetciTelno { get => emanetciTelno; set => emanetciTelno = value; }
        public string Evrakaciklama { get => evrakaciklama; set => evrakaciklama = value; }
        public string Emanetcisoyad { get => emanetcisoyad; set => emanetcisoyad = value; }
        public string Evrakid { get => evrakid; set => evrakid = value; }
    }
}
