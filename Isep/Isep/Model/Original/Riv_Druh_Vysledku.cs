using Isep.Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Isep.Model.Original
{
    public class Riv_Druh_Vysledku : Entity
    {
        public string Nazev { get; set; }
        public string Nazev_en { get; set; }
        public double Vaha { get; set; }
        public string Riv { get; set; }
    }
}
