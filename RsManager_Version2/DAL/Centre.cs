//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Centre
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Centre()
        {
            this.Students = new HashSet<Student>();
        }
    
        public int Id { get; set; }
        public string CentreCode { get; set; }
        public string Description { get; set; }
        public string CentrePicture { get; set; }
        public string PhoneNo { get; set; }
        public string EmailAddress { get; set; }
        public int CityId { get; set; }
        public int SchoolId { get; set; }
    
        public virtual City City { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }
        public virtual School School { get; set; }
    }
}
