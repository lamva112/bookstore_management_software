//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookstoreNMCNPM.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CT_PHIEUNHAPSACH
    {
        public int SoPNS { get; set; }
        public int MaSach { get; set; }
        public int SoLuongNhap { get; set; }
        public int DonGiaNhap { get; set; }
        public Nullable<int> ThanhTien { get; set; }
    
        public virtual PHIEUNHAPSACH PHIEUNHAPSACH { get; set; }
        public virtual SACH SACH { get; set; }
    }
}
