namespace LibraryService.Domain
{
    public class BooksRequest
    {
        public string? Author { get; set; }
        public string? ISBN { get; set; }
        public bool? Own { get; set; }
        public bool? Love { get; set; }
        public bool? Wanted { get; set; }
    }
}
