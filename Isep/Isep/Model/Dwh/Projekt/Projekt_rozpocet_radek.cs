using Isep.Model.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Isep.Model.Dwh
{
    public class Projekt_rozpocet_radek  
    {
        [Key]
        public int Projekt_rozpocet_radek_Id { get; set; }
        public string Cinnost { get; set; }
        public decimal N_Investicni { get; set; }
        public decimal N_Neinvesticni { get; set; }
        public Projekt_rozpocet  Projekt_rozpocet { get; set; }
        public int Rok { get; set; }
    }
}
