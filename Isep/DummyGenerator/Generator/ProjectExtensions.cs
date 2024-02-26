using Isep.Model.Dwh;
using NUnit.Framework.Internal.Execution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyGenerator.Generator
{
    public static class ProjectExtensions
    {
        public static Navrh ToDraft(this Projekt projekt)
        {
            return new Navrh
            {
                Datum_navrhu = projekt.Datum_zahajeni.AddMonths(-6),
                Datum_zahajeni = projekt.Datum_zahajeni,
                Datum_ukonceni = projekt.Datum_ukonceni,
                Navrh_Prac_vazba = projekt.Projekt_prac_vazba.ToDraft(),
                Navrhovatel_gender = projekt.Gender
            };
        }

        public static NAVRH_prac_vazba ToDraft(this Projekt_prac_vazba vazba)
        {
            return new NAVRH_prac_vazba
            {
                Navrh_osoby = vazba.Projekt_osoby.Select(o => o.ToDraft()).ToList(),
            };
        }

        public static NAVRH_osoba ToDraft(this Projekt_Osoba osoba)
        {
            
            var draft = new NAVRH_osoba
            {
                Pohlavi = osoba.Pohlavi,
                Jmeno = osoba.Jmeno,
                Prijmeni = osoba.Prijmeni,
                Titul_pred = osoba.Titul_pred,
                Titul_za = osoba.Titul_za,
                Vav_role = osoba.Vav_role,
            };

            return draft;
        }
    }
}
