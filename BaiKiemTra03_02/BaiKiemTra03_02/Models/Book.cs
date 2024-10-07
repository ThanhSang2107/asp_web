using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiKiemTra03_02.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        public int PublicationYear { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        public Author Author { get; set; } // Điều này giúp liên kết với lớp Author

        [StringLength(100)]
        public string Genre { get; set; }
    }
}