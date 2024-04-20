using EntityFrameworkVip.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkVip.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SinhVienController : ControllerBase
    {

        private readonly MyDbContext _context;
        public SinhVienController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]   
        public IActionResult GetByQery() {

            // var dsSinhVien = _context.sinhViens.Where(sv => sv.Tuoi >= 18 && sv.Tuoi <= 25
            //        && sv.Lop.Khoa.TenKhoa == "CNTT");
            var dsSinhVien = (from sv in _context.sinhViens
                join lop in _context.lops on sv.LopId equals lop.LopId
                join khoa in _context.khoas on lop.KhoaId equals khoa.KhoaId
                where sv.Tuoi >= 18 && sv.Tuoi <= 25 && khoa.TenKhoa == "CNTT"
                select new
                {
                    SinhVienId = sv.SinhVienId,
                    HoTen = sv.HoTen,
                    Tuoi = sv.Tuoi,
                    Lop = new { LopId = lop.LopId, TenLop = lop.TenLop },
                    Khoa = new { KhoaId = khoa.KhoaId, TenKhoa = khoa.TenKhoa }
                }).ToList();
            
            return Ok(dsSinhVien);
        }
        
    }
}
