using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Isep.Model.Dwh;
using System.ComponentModel.DataAnnotations;
using Isep.Model.Shared;


namespace Isep.Model.Dwh
{
    public  class NAVRH_STAV_ciselnik  
    {
        [Key]
        public int Stav_ID { get; set; }
        public string Stav_cely { get; set; }
        public string Stav_cs { get; set; }
        public ICollection<Navrh> Navrhy { get; set; }
    }
}
