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
    using System.Runtime.Serialization;

    [DataContract]
    public class ProgrammeLevelDTO
    {
       [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string ProgrammeDescription { get; set; }
        [DataMember]
        public Nullable<int> ProgId { get; set; }
        [DataMember]
        public Nullable<int> Status { get; set; }
        [DataMember]
        public Nullable<System.DateTime> DateCreated { get; set; }
        [DataMember]
        public int AwardLevelId { get; set; }
    
    }
}