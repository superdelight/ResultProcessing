﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalSolution.Areas.Administration.Models
{
    public class SchoolMDV
    {
        public int Id { get; set; }
        public string SchoolDescription { get; set; }
        public bool IsActive { get; set; }
    }
}