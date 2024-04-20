using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkVip.Data
{
    [Table("sinhvien")]
    public class SinhVien
    {
        [Key]
        public int SinhVienId { get; set; }
        public string HoTen { get; set; }
        public int Tuoi { get; set; }

        public int LopId { get; set; } // Khóa ngoại đến lớp

        [ForeignKey("LopId")]
        public virtual Lop Lop { get; set; }
    }
}
