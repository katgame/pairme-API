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
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryImage { get; set; }
        public DateTime CategoryCreationDate { get; set; }

    }
}
