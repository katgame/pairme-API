using pairme.API.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pairme.API.Core.Entities
{
    public  class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdNumber { get; set; }
        public string PassportNumber { get; set; }
        public Address Location { get; set; }
        public  DateTime Created { get; set; }
         
    }
}
