using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem;

namespace RecipeAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        [HttpGet]
        public List<bizRecipe> Get()
        {
            return new bizRecipe().GetList();
        }

        [HttpGet("searchbyname/{recipenamevalue}")]
        public List<bizRecipe> GetByRecipeName(string recipenamevalue)
        {
            return new bizRecipe().Search(recipenamevalue);
        }

    }
}
