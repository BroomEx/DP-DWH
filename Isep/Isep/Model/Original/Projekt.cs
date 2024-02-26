using Isep.Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isep.Model.Original
{
    public class Projekt : Entity
    {
        public string Kod_MU { get; set; }
        public string Kod_poskytoval { get; set; }
        public string Nazev_cs { get; set; }
        public string Nazev_en { get; set; }
        public DateTime Datum_zahajeni { get; set; }
        public DateTime Datum_ukonceni { get; set; }
        public string Registracni_cislo { get; set; }
        public bool Plati { get; set; }
        public bool Zverejnit { get; set; }
        public string Zapsal { get; set; }
        public DateTime Zapsano { get; set; }
        public string Mu_role_org_id { get; set; }
        public string Ser_fi_uct { get; set; }
        public DateTime Predfin_od { get; set; }
        public string Dokumentace { get; set; }
        public Navrh Navrh { get; set; }
        public string Type { get; set; }
        public string Ident_vyzva { get; set; }
        public string Povereni { get; set; }
        public string Apl_vyzkum { get; set; }
        public string Kod_cep { get; set; }
        public string Tms_mesic_stru { get; set; }
        public string Doc_dir_id { get; set; }
        public string Cal_calendar_id { get; set; }
        public string Tema { get; set; }
        public string Pozn { get; set; }
        public string Zalozil { get; set; }
        public DateTime Zalozeno { get; set; }
        public string GDPR { get; set; }
        public Zdroj_Fin Zdroj_Fin { get; set; }
        public DateTime Udrzitelnost_Do { get; set; }
        public string Gender { get; set; }
        public DateTime Prac_datum { get; set; }
    }
}
