
using FrontToBack1.Models;
using FrontToBack1.Models.Demo;
using FrontToBack1.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack1.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        { 

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderDetail> SliderDetails { get; set; }
        public DbSet<Bio> Bios { get; set; }   
        public DbSet<Product> Products { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<BookImages> BookImages { get; set; }


        public DbSet<Genre> Genres { get; set; }


        public DbSet<SocialPage> SocialPages { get; set; }


        public DbSet<BookGenre> BookGenres { get; set; }

        public DbSet<BookAuthor> BookAuthors { get; set; }


        public DbSet<Author> Authors { get; set; }

    }
}
