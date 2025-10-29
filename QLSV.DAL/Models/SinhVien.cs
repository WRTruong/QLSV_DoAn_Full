namespace QLSV.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SinhVien()
        {
            DangKyHoc = new HashSet<DangKyHoc>();
            Diem = new HashSet<Diem>();
            TaiKhoan = new HashSet<TaiKhoan>();
        }

        [Key]
        public int MaSV { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; }

        public bool? GioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(200)]
        public string DiaChi { get; set; }

        [StringLength(100)]
        public string QueQuan { get; set; }

        [StringLength(20)]
        public string SDT { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public int? MaLop { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayVaoTruong { get; set; }

        [StringLength(255)]
        public string HinhAnh { get; set; }

        [StringLength(20)]
        public string CMND { get; set; }

        [StringLength(50)]
        public string DanToc { get; set; }

        [StringLength(50)]
        public string TonGiao { get; set; }

        [StringLength(20)]
        public string HocLuc { get; set; }

        public double? HocPhi { get; set; }

        public bool? TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangKyHoc> DangKyHoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diem> Diem { get; set; }

        public virtual Lop Lop { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoan> TaiKhoan { get; set; }
    }
}
