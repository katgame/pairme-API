using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;
using pairme.API.Core.Entities;
using pairme.API.Services.Interfaces;

namespace pairme_API.Controllers
{
  //  [Authorize]
    [ApiController]
    [Route("[controller]")]
   // [RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly ICategoryService _categoryService;

        public CategoryController(ILogger<CategoryController> logger, ICategoryService categoryService)
        {
            _logger = logger;

            _categoryService = categoryService;
        }

        [HttpGet(Name = "GetCategories")]
        public IEnumerable<List<Category>> Get()
        {
            yield return _categoryService.GetCategories();
        }
    }
}