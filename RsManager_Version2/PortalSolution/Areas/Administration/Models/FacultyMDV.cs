using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalSolution.Areas.Administration.Models
{
    public class FacultyMDV
    {
        public FacultyMDV()
        {
            Faculty = new Faculty();
            Faculties = new List<Faculty>(); 

        }
       public  Faculty Faculty { get; set; }
       public IEnumerable<Faculty> Faculties { get; set; }
    }
}