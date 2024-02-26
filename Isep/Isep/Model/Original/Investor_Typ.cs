using Isep.Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isep.Model.Original
{
    public class Investor_Typ : Entity
    {
        public string Typ { get; set; }
        public string Nazev_cs { get; set; }
        public string Nazev_en { get; set; }
        public string Popis_cs { get; set; }
        public string Poradi { get; set; }
    }
}
