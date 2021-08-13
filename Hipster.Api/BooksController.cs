using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;

namespace Hipster.Api
{
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet("/")]
        public IActionResult Get()
        {
            return Ok(
                new 
                {
                    Title = "Lord of The Rings",
                    Author = "J.R.R. Tolkien",
                    Year = "1954",
                    ISBN = "123456789"
                 });
        }
    }
}