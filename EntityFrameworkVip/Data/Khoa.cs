using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkVip.Data
{
    [Table("khoa")]
    public class Khoa
    {
        public int KhoaId { get; set; }
        public string TenKhoa { get; set; }

        public virtual ICollection<Lop> Lops { get; set; }
    }
}
