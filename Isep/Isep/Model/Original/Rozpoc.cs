using Isep.Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isep.Model.Original
{
    public class Rozpoc : Entity
    {
        public Projekt Projekt { get; set; }
        public Navrh Navrh { get; set; }
        public double Verze { get; set; }
        public string Smlouva { get; set; }
        public DateTime Platnost_Od { get; set; }
        public string Mena { get; set; }
        public bool Bez_rozpoctu { get; set; }
        public string Duvod { get; set; }
        public string Prenos { get; set; }
        public string Zmenil { get; set; }
        public DateTime Zmeneno { get; set; }
        public string Fin_rmu { get; set; }
    }
}
