

namespace EntityFrameworkVip.Models
{
    public class HangHoaVM
    {
        public string TenHangHoa { get; set; }
        public int DonGia { get; set; }

    }

    public class HangHoa : HangHoaVM
    {
        public Guid MaHangHoa { get; set; }
        

    }

}
