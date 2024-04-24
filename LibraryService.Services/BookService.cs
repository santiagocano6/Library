using LibraryService.Data;
using LibraryService.Domain;
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

        public async Task<List<Book>> GetBooksAsync(BooksRequest request)
        {
            var booksQuery = _context.Books.AsQueryable();
            if (!string.IsNullOrWhiteSpace(request.Author))
            {
                booksQuery = booksQuery.Where(x => request.Author.Contains(x.FirstName) || request.Author.Contains(x.LastName));
            }
            if (!string.IsNullOrWhiteSpace(request.ISBN))
            {
                booksQuery = booksQuery.Where(x => request.ISBN.Contains(x.ISBN));
            }
            if (request.Love.GetValueOrDefault())
            {
                booksQuery = booksQuery.Where(x => x.Love == true);
            }
            if (request.Own.GetValueOrDefault())
            {
                booksQuery = booksQuery.Where(x => x.Own == true);
            }
            if (request.Wanted.GetValueOrDefault())
            {
                booksQuery = booksQuery.Where(x => x.Wanted == true);
            }

            return await booksQuery.ToListAsync();
        }
    }
}
