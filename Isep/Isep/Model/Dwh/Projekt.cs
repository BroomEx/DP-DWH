using Isep.Model.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isep.Model.Dwh
{
    public class Projekt 
    {
        [Key]
        public int Projekt_Id { get; set; }
        public DateTime Datum_zahajeni { get; set; }
        public DateTime? Datum_ukonceni { get; set; }
        public int Projekt_prac_vazba_Id { get; set; }
        public virtual Projekt_prac_vazba Projekt_prac_vazba { get; set; }
        public ICollection<Projekt_rozpocet> Rozpocet { get; set; }
        public int Navrh_Id { get; set; }
        public string Gender { get; set; }
    }
}
