//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RS.DataContract
{
    using System;
    using System.Collections.Generic;
    
    public partial class LGA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LGA()
        {
            this.Students = new HashSet<StudentDTO>();
        }
    
        public int Id { get; set; }
        public string Description { get; set; }
        public int StateId { get; set; }
    
        public virtual StateDTO State { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentDTO> Students { get; set; }
    }
}