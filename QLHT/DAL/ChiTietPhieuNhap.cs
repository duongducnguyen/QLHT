//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLHT.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietPhieuNhap
    {
        public int MaChiTietPhieuNhap { get; set; }
        public Nullable<int> MaPhieuNhap { get; set; }
        public Nullable<int> MaThuoc { get; set; }
        public Nullable<int> SoLuongNhap { get; set; }
    
        public virtual PhieuNhap PhieuNhap { get; set; }
        public virtual Thuoc Thuoc { get; set; }
    }
}
