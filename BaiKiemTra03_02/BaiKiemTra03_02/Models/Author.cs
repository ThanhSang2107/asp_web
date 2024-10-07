using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BaiKiemTra03_02.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Nationality { get; set; }

        public int BirthYear { get; set; }

        public ICollection<Book> Books { get; set; } // Điều này giúp liên kết với nhiều sách
    }
}