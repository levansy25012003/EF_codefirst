using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkVip.Data
{
    [Table("lop")]
    public class Lop
    {
        public int LopId { get; set; }
        public string TenLop { get; set; }

        public int KhoaId { get; set; } // Khóa ngoại đến khoa
        
        
        [ForeignKey("KhoaId")]
        public virtual Khoa Khoa { get; set; }

        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
}
