using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdatkapcsolatGyakorlas
{
    internal class Orszag
    {
        private readonly int ID;
        public string OrszagNeve { get; set; }
        public string Fovaros { get; set; }
        public string FoldrHely { get; set; }
        public float Terulet { get; set; }
        public string Allamforma { get; set; }
        public int Nepesseg { get; set; }
        public int NepFovaros { get; set; }
        public string Autojel { get; set; }
        public string Country { get; set; }
        public string Capital { get; set; }
        public string Penznem { get; set; }
        public string Penzjel { get; set; }
        public string Valtopenz { get; set; }
        public int Telefon { get; set; }
        public int GDP { get; set; }
        public int Kat { get; set; }

        public Orszag(int iD, string orszagNeve, string fovaros, string foldrHely, float terulet, string allamforma, int nepesseg, int nepFovaros, string autojel, string country, string capital, string penznem, string penzjel, string valtopenz, int telefon, int gDP, int kat)
        {
            ID = iD;
            OrszagNeve = orszagNeve;
            Fovaros = fovaros;
            FoldrHely = foldrHely;
            Terulet = terulet;
            Allamforma = allamforma;
            Nepesseg = nepesseg;
            NepFovaros = nepFovaros;
            Autojel = autojel;
            Country = country;
            Capital = capital;
            Penznem = penznem;
            Penzjel = penzjel;
            Valtopenz = valtopenz;
            Telefon = telefon;
            GDP = gDP;
            Kat = kat;
        }
        
        public override string ToString()
        {
            return OrszagNeve;
        }
        
    }
}
