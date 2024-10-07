using Microsoft.EntityFrameworkCore;
using BaiKiemTra03_02.Models; // Thay đổi theo namespace của bạn

namespace BaiKiemTra03_02.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor nhận vào DbContextOptions
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Định nghĩa các DbSet cho các bảng trong CSDL
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}