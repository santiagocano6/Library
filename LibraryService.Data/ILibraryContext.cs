using Microsoft.EntityFrameworkCore;

namespace LibraryService.Data
{
    public interface ILibraryContext : IDisposable
    {
        DbSet<Book> Books { get; set; }
    }
}
