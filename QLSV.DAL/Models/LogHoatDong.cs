namespace QLSV.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogHoatDong")]
    public partial class LogHoatDong
    {
        [Key]
        public int MaLog { get; set; }

        public int MaTK { get; set; }

        public DateTime? ThoiGian { get; set; }

        [StringLength(255)]
        public string HanhDong { get; set; }

        [StringLength(50)]
        public string BangLienQuan { get; set; }

        public int? MaLienQuan { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
