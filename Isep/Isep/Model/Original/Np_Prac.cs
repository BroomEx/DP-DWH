using Isep.Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isep.Model.Original
{
    public class Np_Prac : Entity
    {
        public string Vazpr { get; set; }
        public string Subvazpr { get; set; }
        public Navrh Navrh { get; set; }
        public Projekt Projekt { get; set; }
        public Role_Osoba Role_prac_osoba { get; set; }
        public string Zmenil { get; set; }
        public DateTime Zmeneno { get; set; }

    }
}
