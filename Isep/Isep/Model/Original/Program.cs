using Isep.Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isep.Model.Original
{
    public class Program : Entity
    {
        public string Kod_RVV { get; set; }
        public string Nazev_cs { get; set; }
        public string Nazev_en { get; set; }
        public string Kratky_nazev_cs { get; set; }
        public string Kratky_nazev_en { get; set; }
        public Investor Investor { get; set; }
        public string Program_typ { get; set; }
        public bool Samostatny { get; set; }
        public DateTime Platnost_od { get; set; }
        public DateTime Platnost_do { get; set; }
        public string Kod_vzor { get; set; }
        public string Kompetence_mu_id { get; set; }
        public bool Podp_rekt { get; set; }
        public string TMS_Type_id { get; set; }
        public string Predfin { get; set; }
        public DateTime Udrzitelnost { get; set; }
        public string Skupina { get; set; }
        public string TMS_mesic { get; set; }
        public string Apl_vyzkum { get; set; }
        public string TMS_mesic_stru_def { get; set; }
        public string TMS_mesic_zmena_od { get; set; }
        public double Vaha { get; set; }
        public string Url { get; set; }
        public string Doc_template { get; set; }

    }
}
