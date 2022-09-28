using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pairme.API.Core.Models
{
    public class Price
    {
        //*Flat price or full day *\\
        public double FlatRate { get; set; }

        //*this is an optional value to a complex job *\\
        public string PriceRange { get; set; }
        public double Hourly { get; set; }
        public double Perhead { get; set; }
    }
}
