using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalAdminAPI.Utility
{
    public class SchoolDet
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string Logo { get; set; }
        public string Address { get; set; }
        public Nullable<bool> IsVisible { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public string PhoneNo { get; set; }
        public string EmailAddress { get; set; }
    }
}