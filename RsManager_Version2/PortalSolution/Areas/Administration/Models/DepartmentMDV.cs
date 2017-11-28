using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalSolution.Areas.Administration.Models
{
    public class DepartmentMDV
    {
        public DepartmentMDV()
        {
            Department = new Department();
            Departments = new List<Department>(); 

        }
       public  Department Department { get; set; }
       public IEnumerable<Department> Departments { get; set; }
        public List<SelectListItem> Faculties { get; set; }
    }
}