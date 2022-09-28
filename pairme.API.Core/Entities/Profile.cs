using pairme.API.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pairme.API.Core.Entities
{
    public class Profile
    {
        public Guid Id { get; set; }
        public Category Category { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Price Price { get; set; }
        public string Availability { get; set; }
        public DateTime CategoryCreationDate { get; set; }
    }
}
