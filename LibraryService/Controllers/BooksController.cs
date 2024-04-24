using LibraryService.Data;
using LibraryService.Domain;
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
        public async Task<IEnumerable<Book>> Get([FromQuery]BooksRequest request)
        {
            return await _bookService.GetBooksAsync(request);
        }
    }
}
