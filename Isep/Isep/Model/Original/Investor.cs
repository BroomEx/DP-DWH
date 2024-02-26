using Isep.Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isep.Model.Original
{
    public class Investor : Entity
    {
        public string Kod_rvv { get; set; }
        public string Kod_typu { get; set; }
        public string Nazev_cs { get; set; }
        public string Nazev_en { get; set; }
        public string Zkratka_cs { get; set; }
        public string Zkratka_EN { get; set; }
        public string Http_en { get; set; }
        public string Ser_fi_org { get; set; }
        public string Ser_fi_fir { get; set; }
        public bool Samostatny { get; set; }
        public DateTime Platnost_do { get; set; }
        public DateTime Platnost_od { get; set; }
        public string Kod_vzor { get; set; }
        public int Kompetenece_mu_id { get; set; }
        public string Podp_rekt { get; set; }
        public string Skupina { get; set; }
        public double Vaha { get; set; }
    }
}
