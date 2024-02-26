using Isep.Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isep.Model.Original
{
    public class Np_Dsw : Entity
    {
        public Navrh Navrh { get; set; }
        public Projekt Projekt { get; set; }
        public string Dsw_UUID { get; set; }
        public DateTime Created { get; set; }
        public string Created_by { get; set; }
        public int Package_id { get; set; }
        public string Package_name { get; set; }
        public string Package_version { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Deleted_by { get; set; }
        public DateTime Deleted { get; set; }
    }
}
