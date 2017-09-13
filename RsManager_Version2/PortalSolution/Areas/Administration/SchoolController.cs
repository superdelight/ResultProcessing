using DAL;
using PortalSolution.Areas.Administration.Models;
using ResultBusinessLogic.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalSolution.Areas.Administration
{
    public class SchoolController : Controller
    {
        // GET: Administration/School
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateSchool(SchoolMDV schoolModel)
        {
            SystemSpecificRules bll = new SystemSpecificRules();
            School school = new School() { DateCreated = DateTime.Now, SchoolName = schoolModel.SchoolDescription, IsVisible = schoolModel.IsActive };
            ViewBag.Msg=bll.CreateSchool(school);
            return View();
        }
    }
}