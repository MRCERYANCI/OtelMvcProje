//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtelMvcProje.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblUrun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblUrun()
        {
            this.TblHareket = new HashSet<TblHareket>();
        }
    
        public short UrunId { get; set; }
        public string UrunAd { get; set; }
        public Nullable<byte> UrunGrup { get; set; }
        public Nullable<byte> Birim { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public Nullable<int> Toplam { get; set; }
        public Nullable<byte> Kdv { get; set; }
        public Nullable<int> Durum { get; set; }
    
        public virtual TblBirim TblBirim { get; set; }
        public virtual TblDurum TblDurum { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblHareket> TblHareket { get; set; }
        public virtual TblUrunGrup TblUrunGrup { get; set; }
    }
}