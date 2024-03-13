using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeSystem;

namespace RecipeAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class CookbookController : ControllerBase
    {
        [HttpGet]
        public List<bizCookbook> Get()
        {
            return new bizCookbook().GetList();
        }

        [HttpGet("searchbyid/{bookid}")]
        public List<bizCookbook> GetByBookId(int bookid)
        {
            return new bizCookbook().Search(bookid);
        }
    }
}
