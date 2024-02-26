using Isep.Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isep.Model.Original
{
    public class Np_Text : Entity
    {
        public Projekt Projekt { get; set; }
        public Navrh Navrh { get; set; }
        public string Typ { get; set; }
        public string Text { get; set; }
    }
}
