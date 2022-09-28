using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pairme.API.Core.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        public Guid MasterId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime CategoryCreationDate { get; set; }

    }
}
