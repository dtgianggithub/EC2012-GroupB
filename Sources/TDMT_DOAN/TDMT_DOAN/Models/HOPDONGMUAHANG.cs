//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TDMT_DOAN.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOPDONGMUAHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOPDONGMUAHANG()
        {
            this.CHITIETHOPDONGMUAHANGs = new HashSet<CHITIETHOPDONGMUAHANG>();
        }
    
        public string MAHOPDONG { get; set; }
        public string NHACUNGCAP { get; set; }
        public string SANPHAM { get; set; }
        public Nullable<int> SOLUONGTONKHOTOITHIEU { get; set; }
        public Nullable<int> THOIGIANGIAOHANGCHAPNHAN { get; set; }
        public Nullable<System.DateTime> THOIGIANKI { get; set; }
        public Nullable<int> THOIGIANHOPTAC { get; set; }
        public Nullable<int> THOIGIANCHUYENTIEN { get; set; }
        public Nullable<int> SOLUONGGIAOHANG { get; set; }
        public string LINKWEBAPI { get; set; }
        public Nullable<bool> DAXOA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOPDONGMUAHANG> CHITIETHOPDONGMUAHANGs { get; set; }
        public virtual NHACUNGCAP NHACUNGCAP1 { get; set; }
        public virtual SANPHAM SANPHAM1 { get; set; }
    }
}
