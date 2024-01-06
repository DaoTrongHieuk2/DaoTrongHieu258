using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DaoTrongHieu258.Models;
[Table("SinhVien")]
public class SinhVien
{
    [Key]
    [Display(Name = "Mã Sinh Viên")]
    public string? MaSinhVien { get; set; }
    public DateTime NgaySinh { get; set; }
    [Display(Name = "Số Điện Thoại")]
    public int SoDienThoai { get; set; }

}