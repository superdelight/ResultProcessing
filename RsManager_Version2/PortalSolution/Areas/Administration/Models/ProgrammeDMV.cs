using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalSolution.Areas.Administration.Models
{
    public class ProgrammeDMV
    {
        public ProgrammeDMV()
        {
            Departments = new List<SelectListItem>();
            Programmes = new List<Programme>();
        }
        public int Id { get; set; }
        public string ProgrammeDescription { get; set; }
        public string ProgrammeCode { get; set; }
        public int DeptId { get; set;}
        public List<Programme> Programmes { get; set; }
        public List<SelectListItem> Departments { get; set; }
    }
}