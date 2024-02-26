using Isep.Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Isep.Model.Original
{
    public class Rozpoc_Radek : Entity
    {
        public Rozpoc Rozpocet { get; set; }
        public Zdroj_Fin Rozp_zdroj { get; set; }
        public Investor Investor { get; set; }
        public DateTime Rok { get; set; }
        public string Subjekt { get; set; }
        public string Vazpr { get; set; }
        public string Cinnost { get; set; }
        public string Nei { get; set; }
        public string Inv { get; set; }
        public ICollection<Rozpoc_Radek> Rozpoc_Radky { get; set; }
    }
}
