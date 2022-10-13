using pairme.API.Core.Context;
using pairme.API.Core.Entities;
using pairme.API.Services.Interfaces;

namespace pairme.API.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly pairme_APIContext _dbContext;

        public CategoryService(pairme_APIContext appDbContext)
        {
            this._dbContext = appDbContext;
        }

        public  List<Category> GetCategories()
        {
            return _dbContext.Category.ToList();
        }
    }
}