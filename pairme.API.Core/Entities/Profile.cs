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
        public Guid User { get; set; }
        public string ProfileName { get; set; }
        public string ProfileDescription { get; set; }
        public string ProfileImage { get; set; }
        public DateTime CategoryCreationDate { get; set; }
    }
}
