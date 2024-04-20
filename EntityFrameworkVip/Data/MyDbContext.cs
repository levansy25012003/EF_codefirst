using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkVip.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }


        public DbSet<HangHoa> HangHoas { get; set; }
        public DbSet<Loai> Loais { get; set; }

        public DbSet<SinhVien> sinhViens { get; set; }
        public DbSet<Lop> lops { get; set; }
        public DbSet<Khoa> khoas { get; set; }

    }
}
