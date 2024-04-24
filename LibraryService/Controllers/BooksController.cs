using LibraryService.Data;
using LibraryService.Services;
using Microsoft.AspNetCore.Mvc;

namespace LibraryService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet(Name = "GetBooks")]
        public async Task<IEnumerable<Book>> Get()
        {
            return await _bookService.GetBooksAsync();
        }
    }
}
