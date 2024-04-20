using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkVip.Migrations
{
    /// <inheritdoc />
    public partial class createSVlopKhoa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "khoa",
                columns: table => new
                {
                    KhoaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhoa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khoa", x => x.KhoaId);
                });

            migrationBuilder.CreateTable(
                name: "lop",
                columns: table => new
                {
                    LopId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KhoaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lop", x => x.LopId);
                    table.ForeignKey(
                        name: "FK_lop_khoa_KhoaId",
                        column: x => x.KhoaId,
                        principalTable: "khoa",
                        principalColumn: "KhoaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sinhvien",
                columns: table => new
                {
                    SinhVienId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tuoi = table.Column<int>(type: "int", nullable: false),
                    LopId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sinhvien", x => x.SinhVienId);
                    table.ForeignKey(
                        name: "FK_sinhvien_lop_LopId",
                        column: x => x.LopId,
                        principalTable: "lop",
                        principalColumn: "LopId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_lop_KhoaId",
                table: "lop",
                column: "KhoaId");

            migrationBuilder.CreateIndex(
                name: "IX_sinhvien_LopId",
                table: "sinhvien",
                column: "LopId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sinhvien");

            migrationBuilder.DropTable(
                name: "lop");

            migrationBuilder.DropTable(
                name: "khoa");
        }
    }
}
