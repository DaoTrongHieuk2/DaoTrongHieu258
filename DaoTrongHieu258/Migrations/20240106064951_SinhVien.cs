using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DaoTrongHieu258.Migrations
{
    /// <inheritdoc />
    public partial class SinhVien : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SinhVien",
                columns: table => new
                {
                    MaSinhVien = table.Column<string>(type: "TEXT", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SoDienThoai = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhVien", x => x.MaSinhVien);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SinhVien");
        }
    }
}
