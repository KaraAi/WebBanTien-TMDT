//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BanTien.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Admin
    {
        public int MaAD { get; set; }
        public string HoAD { get; set; }
        public string TenAD { get; set; }
        public string UsernameAD { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string AnhDaiDien { get; set; }
        public string DienThoai { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
    
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
