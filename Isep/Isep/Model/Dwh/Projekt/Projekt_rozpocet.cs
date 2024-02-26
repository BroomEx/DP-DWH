using Isep.Model.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isep.Model.Dwh
{
    public class Projekt_rozpocet  
    {
        [Key]
        public int Projekt_rozpocet_Id { get; set; }
        public DateTime Platnost_od { get; set; }
        public string Mena { get; set; }
        public ICollection<Projekt_rozpocet_radek> Rozpocet_radky { get; set; }
    }
}
