using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pairme.API.Core.Models
{
    public class Address
    {
        public string StreetName { get; set; }
        public string Line1 {get;set;}
        public string Line2 { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

    }
}
