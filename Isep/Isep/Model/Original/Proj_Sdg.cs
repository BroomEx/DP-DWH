using Isep.Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isep.Model.Original
{
    public class Proj_Sdg : Entity
    {
        public Projekt Projekt { get; set; }
        public int Sdg_Cislo { get; set; }
        public int Uroven { get; set; }
    }
}
