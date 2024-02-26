using Isep.Model.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isep.Model.Dwh
{
    public class Vav_role_osoba
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public char ROLE_OSOBA_ID { get; set; }
        public string Popis { get; set; }
        public ICollection<Projekt_Osoba> Projekt_osoby { get; set; }
        public ICollection<NAVRH_osoba> Navrh_osoby { get; set; }

        public Vav_role_osoba()
        {
            Projekt_osoby = new HashSet<Projekt_Osoba>();
            Navrh_osoby = new HashSet<NAVRH_osoba>();
        }
    }
}
