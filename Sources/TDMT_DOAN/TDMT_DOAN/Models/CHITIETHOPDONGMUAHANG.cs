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
    
    public partial class CHITIETHOPDONGMUAHANG
    {
        public int MA { get; set; }
        public string MAHOPDONG { get; set; }
        public string MASANPHAM { get; set; }
        public Nullable<int> SOLUONGTONKHOTOITHIEU { get; set; }
        public Nullable<int> THOIGIANGIAOHANGCHAPNHAN { get; set; }
        public Nullable<System.DateTime> THOIGIANKI { get; set; }
        public Nullable<int> THOIGIANHOPTAC { get; set; }
        public Nullable<int> THOIGIANCHUYENTIEN { get; set; }
        public Nullable<int> SOLUONGGIAOHANG { get; set; }
        public Nullable<bool> DAXOA { get; set; }
    
        public virtual HOPDONGMUAHANG HOPDONGMUAHANG { get; set; }
        public virtual SANPHAM SANPHAM { get; set; }
    }
}
