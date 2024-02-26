using Isep.Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isep.Model.Original
{
    public class Podprogram : Entity
    {
        public string Nazev_cs { get; set; }
        public string Nazev_en { get; set; }
        public string Kratky_nazev_cs { get; set; }
        public string Kratky_nazev_en { get; set; }
        public Program Program { get; set; }
        public DateTime Platnost_od { get; set; }
        public DateTime Platnbost_do { get; set; }
        public string Kod_vzor { get; set; }
        public string Apl_vyzkum { get; set; }
        public double Vaha { get; set; }
        public string Skupina { get; set; }
        public string Kompetence_mu_id { get; set; }
    }
}
