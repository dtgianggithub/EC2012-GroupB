﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TMDT_DB3Entities : DbContext
    {
        public TMDT_DB3Entities()
            : base("name=TMDT_DB3Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<API> APIs { get; set; }
        public virtual DbSet<CHITIETDONHANG> CHITIETDONHANGs { get; set; }
        public virtual DbSet<CHITIETHOPDONGBANHANG> CHITIETHOPDONGBANHANGs { get; set; }
        public virtual DbSet<CHITIETHOPDONGMUAHANG> CHITIETHOPDONGMUAHANGs { get; set; }
        public virtual DbSet<DONHANG> DONHANGs { get; set; }
        public virtual DbSet<HOPDONGBANHANG> HOPDONGBANHANGs { get; set; }
        public virtual DbSet<HOPDONGMUAHANG> HOPDONGMUAHANGs { get; set; }
        public virtual DbSet<KHUYENMAI> KHUYENMAIs { get; set; }
        public virtual DbSet<LOAISANPHAM> LOAISANPHAMs { get; set; }
        public virtual DbSet<LOAITHANHVIEN> LOAITHANHVIENs { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<NHASANXUAT> NHASANXUATs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<THANHTOANONLINE> THANHTOANONLINEs { get; set; }
        public virtual DbSet<THANHVIEN> THANHVIENs { get; set; }
        public virtual DbSet<TRANGTHAIDONHANG> TRANGTHAIDONHANGs { get; set; }
    }
}
