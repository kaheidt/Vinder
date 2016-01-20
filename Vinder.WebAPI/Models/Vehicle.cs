using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vinder.WebAPI.Models
{
    public class Vehicle
    {
        public string Vin { get; set; }
        public decimal Distance { get; set; }
        public string MasterImage { get; set; }
        public string[] Images { get; set; }
        public Dictionary<string, string> AttributesDictionary { get; set; } 
    }
}