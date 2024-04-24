using LibraryService.Data;

namespace LibraryService.Services
{
    public interface IBookService : IDisposable
    {
        Task<List<Book>> GetBooksAsync();
    }
}
