using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QLSV.DAL;

[Table("ThongBao")] // b?t EF dùng ?úng tên b?ng
public partial class ThongBao
{
    [Key]
    public int MaTB { get; set; }

    [StringLength(100)]
    public string TieuDe { get; set; }

    public string NoiDung { get; set; }
    public DateTime? NgayTB { get; set; }
    public int? MaSV { get; set; }
    public int? MaLop { get; set; }
    public int? MaTK { get; set; }

    [ForeignKey("MaLop")]
    public virtual Lop Lop { get; set; }

    [ForeignKey("MaTK")]
    public virtual TaiKhoan TaiKhoan { get; set; }

    [ForeignKey("MaSV")]
    public virtual SinhVien SinhVien { get; set; }
}
