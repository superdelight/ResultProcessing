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
    public  class CentreDTO
    {
  
    [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string CentreCode { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string CentrePicture { get; set; }
        [DataMember]
        public string PhoneNo { get; set; }
        [DataMember]
        public string EmailAddress { get; set; }
        [DataMember]
        public int CityId { get; set; }
        [DataMember]
        public int SchoolId { get; set; }
    
    
    }
}
