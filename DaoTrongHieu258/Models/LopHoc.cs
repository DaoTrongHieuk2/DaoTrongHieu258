using System.Reflection.Emit;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DaoTrongHieu258.Models;
[Table("LopHoc")]
public class LopHoc
{
    [Key]
    [Display(Name = "Mã Lớp Học")]
    public string? MaLopHoc { get; set; }
    [Display(Name = "Tên Lớp Học")]
    public string? TenLopHoc { get; set; }
    [Display(Name = "Mã Sinh Viên")]
    public string? MaSinhVien { get; set; }
    [ForeignKey("MaSinhVien")]
    public SinhVien? SinhVien { get; set; }
}