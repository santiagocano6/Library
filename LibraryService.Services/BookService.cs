using LibraryService.Data;
using LibraryService.Domain;
using Microsoft.EntityFrameworkCore;

namespace LibraryService.Services
{
    public class BookService : IBookService
    {
        ILibraryContext _context;
        public BookService(ILibraryContext context)
        {
            _context = context;
            OnSaveMessageEvent += OnSaveMessageHandler;
        }

        public void Dispose()
        {
        }

        public event EventHandler<string> OnSaveMessageEvent;

        protected virtual void OnSaveMessageHandler(object? sender, string message)
        {
            //Save message into logs
            Console.WriteLine(message);
        }


        public async Task<List<Book>> GetBooksAsync(BooksRequest request)
        {
            try
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

                var response = await booksQuery.ToListAsync();
                OnSaveMessageEvent.Invoke(this, $"GetBooksAsync: {response.Count} books retrieved");

                return response;
            }
            catch(Exception ex)
            {
                OnSaveMessageEvent.Invoke(this, $"GetBooksAsync: {ex.Message}");
                throw;
            }
        }
    }
}
