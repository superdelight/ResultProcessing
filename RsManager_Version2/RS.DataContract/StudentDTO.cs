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
    public  class StudentDTO
    {
        
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string MatricNo { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public string Othername { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string StateofOrigin { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public Nullable<int> YearofAdmission { get; set; }
        [DataMember]
        public string ModeofAdmission { get; set; }
        [DataMember]
        public string NameofNextofKin { get; set; }
        [DataMember]
        public string PhoneNoNextofKin { get; set; }
        [DataMember]
        public string Relationship { get; set; }
        [DataMember]
        public Nullable<int> ProgrammeId { get; set; }
        [DataMember]
        public Nullable<int> Status { get; set; }
        [DataMember]
        public Nullable<System.DateTime> DateCreated { get; set; }
        [DataMember]
        public int CentreId { get; set; }
        [DataMember]
        public int LGAId { get; set; }
        [DataMember]
        public string Picture { get; set; }
        [DataMember]
        public string Signature { get; set; }
        [DataMember]
        public System.DateTime DOB { get; set; }
        [DataMember]
        public string PlaceofBirth { get; set; }
        [DataMember]
        public string Genotype { get; set; }
        [DataMember]
        public string BloodGroup { get; set; }
    
  
    }
}