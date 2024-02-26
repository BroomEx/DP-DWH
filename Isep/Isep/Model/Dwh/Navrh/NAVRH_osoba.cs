using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Isep.Model.Shared;


namespace Isep.Model.Dwh
{
    public class NAVRH_osoba
    {
        [Key]
        public int Navrh_Osoba_Id { get; set; }
        public string Pohlavi { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Titul_pred { get; set; }
        public string Titul_za { get; set; }
        public virtual Vav_role_osoba Vav_role { get; set; }
        public int Navrh_Prac_vazbaId { get; set; }
        public virtual NAVRH_prac_vazba Navrh_Prac_vazba { get; set; }
    }
}
