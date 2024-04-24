using Microsoft.EntityFrameworkCore;

namespace LibraryService.Data
{
    public class LibraryContext : DbContext, ILibraryContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
