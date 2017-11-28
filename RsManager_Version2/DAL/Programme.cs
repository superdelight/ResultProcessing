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
    
    public partial class Programme
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Programme()
        {
            this.ProgrammeLevels = new HashSet<ProgrammeLevel>();
            this.Students = new HashSet<Student>();
            this.ProgrammeReqs = new HashSet<ProgrammeReq>();
        }
    
        public int Id { get; set; }
        public string ProgrammeDescription { get; set; }
        public string ProgrammeCode { get; set; }
        public Nullable<int> deptId { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<int> ExpectedGraduationYear { get; set; }
    
        public virtual Department Department { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProgrammeLevel> ProgrammeLevels { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProgrammeReq> ProgrammeReqs { get; set; }
    }
}
