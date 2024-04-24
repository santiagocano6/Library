using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryService.Data
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Column("book_id")]
        public int BookId { get; set; }
        [Required]
        [Column("title")]
        public string Title { get; set; }
        [Required]
        [MaxLength(50)]
        [Column("first_name")]
        public string FirstNname { get; set; }
        [Required]
        [MaxLength(50)]
        [Column("last_name")]
        public string LastName { get; set; }
        [Required]
        [Column("total_copies")]
        public int TotalCopies { get; set; }
        [Required]
        [Column("copies_in_use")]
        public int CopiesInUse { get; set; }
        [MaxLength(80)]
        [Column("type")]
        public string? Type { get; set; }
        [MaxLength(50)]
        [Column("isbn")]
        public string? ISBN { get; set; }
        [MaxLength(80)]
        [Column("category")]
        public string? Category { get; set; }
    }
}
