using LibraryService.Data;
using LibraryService.Domain;

namespace LibraryService.Services
{
    public interface IBookService : IDisposable
    {
        Task<List<Book>> GetBooksAsync(BooksRequest request);
    }
}
