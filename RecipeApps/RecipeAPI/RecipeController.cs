using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem;

namespace RecipeAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        //[HttpGet]
        //public List<bizRecipe> Get()
        //{
        //    var lst = new bizRecipe().GetList();
        //    return lst;
        //}

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

        [HttpGet("searchbycuisine/{id}")]
        public List<bizRecipe> GetByCuisineID(int id)
        {
            var lst = new bizRecipe().SearchByCuisine(id);
            return lst;
        }


        [HttpGet("cuisineget")]
        public List<bizCuisine> GetCuisine()
        {
            var lst = new bizCuisine().GetList();
            return lst;
        }

        [HttpGet("users")]
        public List<bizUsers> UserGet()
        {
            return new bizUsers().GetList();
        }


        [HttpPost]
        public IActionResult Post([FromForm] bizRecipe recipe)
        {
            try
            {
                recipe.Save();
                return Ok(new { message = "Recipe Saved.", recipeid = recipe.RecipeId });
            }
            catch (Exception ex)
            {
                return BadRequest(new { ex.Message });
            }
        }

    }
}
