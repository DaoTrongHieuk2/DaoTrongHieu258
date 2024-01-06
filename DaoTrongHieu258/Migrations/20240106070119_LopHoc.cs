using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DaoTrongHieu258.Migrations
{
    /// <inheritdoc />
    public partial class LopHoc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LopHoc",
                columns: table => new
                {
                    MaLopHoc = table.Column<string>(type: "TEXT", nullable: false),
                    TenLopHoc = table.Column<string>(type: "TEXT", nullable: true),
                    MaSinhVien = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHoc", x => x.MaLopHoc);
                    table.ForeignKey(
                        name: "FK_LopHoc_SinhVien_MaSinhVien",
                        column: x => x.MaSinhVien,
                        principalTable: "SinhVien",
                        principalColumn: "MaSinhVien");
                });

            migrationBuilder.CreateIndex(
                name: "IX_LopHoc_MaSinhVien",
                table: "LopHoc",
                column: "MaSinhVien");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LopHoc");
        }
    }
}
