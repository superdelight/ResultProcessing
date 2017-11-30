using DAL;
using PortalSolution.Areas.Administration.Models;
using ResultBusinessLogic.Implementation;
using ResultBusinessLogic.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalSolution.Areas.Administration.Controllers
{
    public class FacultyController : Controller
    {
        // GET: Administration/Faculty
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateNewFaculty()
        {
            SystemSpecificRules bll = new SystemSpecificRules();
            FacultyMDV fac = new FacultyMDV();
             fac.Faculties = bll.GetAllFaculties();
            
            return View(fac);
        }
        [HttpPost]
        public ActionResult CreateNewFaculty(FacultyMDV fac)
        {
            int[] x = new[] { 1, 2, 5, 3 };
            ViewBag.Message = null;
            ViewBag.Signal = null;
            var faculty = fac.Faculty;
            SystemSpecificRules bll = new SystemSpecificRules();
            var response= bll.CreateFaculty(faculty);
            ViewBag.Message = response.Message;
            if (response.Response == ResponseCode.OK)
            {
                fac.Faculties = response.Result;
                ViewBag.Signal = "success";
            }
            else
            {
                fac.Faculties = bll.GetAllFaculties();
                ViewBag.Signal = "error";
            }
            return View(fac);
        }
        public ActionResult ViewFaculties()
        {
            return View();
        }
    }
}