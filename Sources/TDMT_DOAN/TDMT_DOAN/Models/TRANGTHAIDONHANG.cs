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
    
    public partial class TRANGTHAIDONHANG
    {
        public TRANGTHAIDONHANG()
        {
            this.DONHANGs = new HashSet<DONHANG>();
        }
    
        public int MA { get; set; }
        public string TINHTRANG { get; set; }
        public Nullable<bool> DAXOA { get; set; }
    
        public virtual ICollection<DONHANG> DONHANGs { get; set; }
    }
}
