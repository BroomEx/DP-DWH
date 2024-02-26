using Isep.Model.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isep.Model.Dwh
{
    public class Projekt_Osoba  
    {
        [Key]
        public int Projekt_Osoba_Id { get; set; }
        public string Pohlavi { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Titul_pred { get; set; }
        public string Titul_za { get; set; }
        public Vav_role_osoba Vav_role { get; set; }
        public int Projekt_Prac_vazbaId { get; set; }
        public virtual Projekt_prac_vazba Projekt_Prac_vazba { get; set; }
    }
}
