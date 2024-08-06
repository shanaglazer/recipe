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
            var lst = new bizRecipe().GetList();
            return lst;
        }

        [HttpGet("searchbybook")]
        public List<bizRecipe> GetByBookId(int id)
        {
            var lst = new bizRecipe().SearchByBook(id);
            return lst;
        }

        [HttpGet("searchbyname/{recipenamevalue}")]
        public List<bizRecipe> GetByRecipeName(string recipenamevalue)
        {
            return new bizRecipe().Search(recipenamevalue);
        }

    }
}
