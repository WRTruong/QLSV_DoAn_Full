namespace QLSV.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongBao")]
    public partial class ThongBao
    {
        [Key]
        public int MaTB { get; set; }

        [StringLength(100)]
        public string TieuDe { get; set; }

        public string NoiDung { get; set; }

        public DateTime? NgayTB { get; set; }

        public int? MaLop { get; set; }

        public int? MaTK { get; set; }

        public virtual Lop Lop { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
