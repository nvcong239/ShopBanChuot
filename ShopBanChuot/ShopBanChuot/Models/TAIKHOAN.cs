//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopBanChuot.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TAIKHOAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TAIKHOAN()
        {
            this.MaNhomTK = 2;
            this.DONHANGs = new HashSet<DONHANG>();
        }
    
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string TenKhachHang { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public Nullable<int> MaNhomTK { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONHANG> DONHANGs { get; set; }
        public virtual NHOMTAIKHOAN NHOMTAIKHOAN { get; set; }
    }
}
