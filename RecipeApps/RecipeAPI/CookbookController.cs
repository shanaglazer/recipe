using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem;

namespace RecipeAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class CookbookController : ControllerBase
    {
        //[HttpGet]
        //public List<bizRecipe> Get()
        //{
        //    return new bizRecipe().GetList();
        //}
    }
}
