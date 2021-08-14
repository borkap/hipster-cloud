using Microsoft.EntityFrameworkCore;

namespace Hipster.Api
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Lord of The Rings",
                    Author = "J.R.R. Tolkien",
                    Year = 1954,
                    ISBN = "123456789",
                    Description = "A great book!",
                    CoverImageUrl = "https://www.britishbook.ua/upload/resize_cache/iblock/add/430_648_174b5ed2089e1946312e2a80dcd26f146/kniga_the_lord_of_the_rings.jpg"
                 },
                 new Book 
                 {         
                    Id = 2,        
                    Title = "Harry Potter",
                    Author = "J. K. Rowling",
                    Year = 1997,
                    ISBN = "987654321",
                    Description = "A great book!",
                    CoverImageUrl = "https://media.wired.com/photos/59337fd358b0d64bb35d5bab/191:100/w_1280,c_limit/HP1-covers.jpg"
                 },
                 new Book 
                 {         
                    Id = 3,        
                    Title = "Lonely Planet",
                    Author = "Tom De Smedt",
                    Year = 2004,
                    ISBN = "98765432132",
                    Description = "A great book!",
                    CoverImageUrl = "https://play-lh.googleusercontent.com/GN8RZW5g_sS4qs-zZqg1uiyzLBN_BsB9zph7KHj5lJ4t-3_xjRA9nB4bIjfteBdpaQI"
                 }
            );
        }
    }
}