using Microsoft.AspNetCore.Mvc;

namespace Hipster.Api
{
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet("/")]
        [ProducesResponseType(typeof(Book), 200)]
        public IActionResult Get()
        {
            return Ok(new Book[]
            {
                new Book
                {
                    Title = "Lord of The Rings",
                    Author = "J.R.R. Tolkien",
                    Year = 1954,
                    ISBN = "123456789",
                    Description = "A great book!",
                    CoverImageUrl = "http://www.google.com/1.png "
                 },
                 new Book 
                 {                 
                    Title = "Harry Potter",
                    Author = "J. K. Rowling",
                    Year = 1997,
                    ISBN = "987654321",
                    Description = "A great book!",
                    CoverImageUrl = "http://www.google.com/1.png"
                 }
            });
        }
    }
}