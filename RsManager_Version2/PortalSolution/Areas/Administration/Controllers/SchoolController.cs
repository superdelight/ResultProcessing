using DAL;
using PortalSolution.Areas.Administration.Models;
using ResultBusinessLogic.Implementation;
using ResultBusinessLogic.Utility;
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
        public ActionResult CreateSchool()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSchool(SchoolMDV schoolModel)
        {
            ViewBag.Message = null;
            ViewBag.Signal = null;
          SystemSpecificRules bll = new SystemSpecificRules();
            School school = new School() { DateCreated = DateTime.Now, SchoolName = schoolModel.SchoolDescription, IsVisible = schoolModel.IsActive };
           var reply= bll.CreateSchool(school);
            ViewBag.Message = reply.Message;
            if (reply.Response==ResponseCode.OK)
            {
                ViewBag.Signal = "success";
            }
            else
            {
                ViewBag.Signal = "error";
            }
            return View();
        }
    }
}