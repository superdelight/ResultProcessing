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
    
    public partial class SessionSem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SessionSem()
        {
            this.Registrations = new HashSet<Registration>();
        }
    
        public int Id { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CommencementDate { get; set; }
        public Nullable<System.DateTime> NormalClosureDate { get; set; }
        public Nullable<System.DateTime> DateOpened { get; set; }
        public string OpenedBy { get; set; }
        public Nullable<System.DateTime> ClosedTime { get; set; }
        public string ClosedBy { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> SemId { get; set; }
        public Nullable<int> SessId { get; set; }
    
        public virtual Semester Semester { get; set; }
        public virtual Session Session { get; set; }
        public virtual SessionStatu SessionStatu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
