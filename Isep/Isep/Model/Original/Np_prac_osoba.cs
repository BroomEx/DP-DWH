using Isep.Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isep.Model.Original
{
    public class Np_prac_osoba : Entity
    {
        public string Oscis { get; set; }
        public string Akademik { get; set; }
        public Role_Osoba Role_Osoba { get; set; }
        public Np_Prac Np_Prac { get; set; }
    }
}
