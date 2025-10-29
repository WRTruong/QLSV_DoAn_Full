namespace QLSV.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HocKy")]
    public partial class HocKy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HocKy()
        {
            DangKyHoc = new HashSet<DangKyHoc>();
            LichHoc = new HashSet<LichHoc>();
        }

        [Key]
        public int MaHK { get; set; }

        [Required]
        [StringLength(50)]
        public string TenHK { get; set; }

        [Required]
        [StringLength(20)]
        public string NamHoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangKyHoc> DangKyHoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichHoc> LichHoc { get; set; }
    }
}
