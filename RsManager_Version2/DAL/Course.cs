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
    
    public partial class Course
    {
        public int Id { get; set; }
        public string CourseCode { get; set; }
        public string CourseTitle { get; set; }
        public Nullable<int> DeptId { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
