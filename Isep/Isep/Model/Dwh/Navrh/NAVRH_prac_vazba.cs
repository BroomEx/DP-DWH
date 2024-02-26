using Isep.Model.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isep.Model.Dwh
{
    public class NAVRH_prac_vazba  
    {
        [Key]
        public int Navrh_prac_vazba_Id { get; set; }
        public int Navrh_Id { get; set; }
        public virtual Navrh Navrh { get; set; }
        public ICollection<NAVRH_osoba> Navrh_osoby { get; set; }

    }
}
