namespace QLSV.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichHoc")]
    public partial class LichHoc
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLop { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaMH { get; set; }

        public int MaGV { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHK { get; set; }

        [Required]
        [StringLength(10)]
        public string Thu { get; set; }

        public int TietBatDau { get; set; }

        public int SoTiet { get; set; }

        public virtual GiangVien GiangVien { get; set; }

        public virtual HocKy HocKy { get; set; }

        public virtual Lop Lop { get; set; }

        public virtual MonHoc MonHoc { get; set; }
    }
}
