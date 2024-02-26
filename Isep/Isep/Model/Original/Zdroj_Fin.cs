using Isep.Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isep.Model.Original
{
    public class Zdroj_Fin : Entity
    {
        public Investor Investor { get; set; }
        public Program Program { get; set; }
        public Podprogram Podprogram { get; set; }
    }
}
