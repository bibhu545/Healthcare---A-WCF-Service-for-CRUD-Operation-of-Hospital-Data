//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class doctors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public doctors()
        {
            this.documents = new HashSet<documents>();
        }
    
        public int doctorid { get; set; }
        public int userid { get; set; }
        public int hospitalid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int speciality { get; set; }
        public string address { get; set; }
        public string phone1 { get; set; }
        public string phone2 { get; set; }
        public string email { get; set; }
        public Nullable<int> isprimary { get; set; }
    
        public virtual hospitals hospitals { get; set; }
        public virtual speciality speciality1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<documents> documents { get; set; }
    }
}