using LibraryService.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LibraryService.Services
{
    public class BookService : IBookService
    {
        ILibraryContext _context;
        public BookService(ILibraryContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            
        }

        public async Task<List<Book>> GetBooksAsync()
        {
            var result = await _context.Books.ToListAsync();
            return result;
        }
    }
}
