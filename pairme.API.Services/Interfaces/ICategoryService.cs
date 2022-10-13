
using pairme.API.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pairme.API.Services.Interfaces
{
    public interface ICategoryService 
    {
        List<Category> GetCategories();
    }
}
