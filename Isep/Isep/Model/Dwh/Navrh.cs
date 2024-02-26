using Isep.Model.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isep.Model.Dwh
{
    public class Navrh
    {
        [Key]
        public int Navrh_Id { get; set; }
        public DateTime Datum_navrhu { get; set; }
        public DateTime? Datum_zahajeni { get; set; }
        public DateTime? Datum_ukonceni { get; set; }
        public NAVRH_prac_vazba Navrh_Prac_vazba { get; set; }
        public string Navrhovatel_gender { get; set; }
    }
}
