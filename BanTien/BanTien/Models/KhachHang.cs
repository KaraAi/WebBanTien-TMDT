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
    
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            this.DanhGiaTiens = new HashSet<DanhGiaTien>();
            this.GioHangs = new HashSet<GioHang>();
        }
    
        public int MaKH { get; set; }
        public string HoKH { get; set; }
        public string TenKH { get; set; }
        public string UsernameKH { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string AnhDaiDien { get; set; }
        public string DienThoai { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public Nullable<int> GiamGia { get; set; }
        public Nullable<short> SoLanHuyDon { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhGiaTien> DanhGiaTiens { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GioHang> GioHangs { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
