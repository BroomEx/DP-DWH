using Isep.Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isep.Model.Original
{
    public class Navrh : Entity
    {
        public string Nazev { get; set; }
        public string Kod { get; set; }
        public string Navrhovatel { get; set; }
        public Zdroj_Fin Zdroj_Fin { get; set; }
        public string Akronym { get; set; }
        public string Anotace { get; set; }
        public DateTime Datum_zahajeni { get; set; }
        public DateTime Datum_ukonceni { get; set; }
        public DateTime Datum_navrhu { get; set; }
        public string Reg_cislo { get; set; }
        public string Dokumentace { get; set; }
        public string Typ { get; set; }
        public string Ident_vyzva { get; set; }
        public int Mu_role_org_id { get; set; }
        public bool Plati { get; set; }
        public string Zapsal { get; set; }
        public DateTime Zapsano { get; set; }
        public int Navrh_stav_id { get; set; }
        public string Smazal { get; set; }
        public DateTime Smazano { get; set; }
        public DateTime Predfin_od { get; set; }
        public string Apl_vyzkum { get; set; }
        public int Doc_dic_id { get; set; }
        public string Tema { get; set; }
        public string Etika { get; set; }
        public string Etika_stav { get; set; }
        public string Etika_cislo { get; set; }
        public string Pozn { get; set; }
        public string Zalozil { get; set; }
        public DateTime Zalozeno { get; set; }
        public string GDPR { get; set; }
        public string Nazev_en { get; set; }
        public string Navrhovatel_gender { get; set; }  
        public string Navrhovatel_typ { get; set; }
        public string Dalsi_info { get; set; }
        public DateTime Udrzitelnost_do { get; set; }
    }
}
