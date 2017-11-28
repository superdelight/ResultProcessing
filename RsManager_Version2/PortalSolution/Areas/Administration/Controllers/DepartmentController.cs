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
    public class DepartmentController : Controller
    {
        // GET: Administration/Department
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateNewDepartment()
        {
            
            SystemSpecificRules bll = new SystemSpecificRules();
            DepartmentMDV dept = new DepartmentMDV();
             dept.Departments = bll.GetAllDepartments(1);
            dept.Faculties = bll.GetAllFaculties().Select(m=>new SelectListItem() { Value = m.Id.ToString(), Text = m.FacName }).ToList();
            
            return View(dept);
        }
        [HttpPost]
        public ActionResult ReRopulate(string FacId)
        {
            int facId = int.Parse(FacId);
            SystemSpecificRules bll = new SystemSpecificRules();
            var dept = bll.GetAllDepartments(facId);
            
            DepartmentMDV dpm = new Models.DepartmentMDV();
            dpm.Faculties = bll.GetAllFaculties().Select(m => new SelectListItem() { Value = m.Id.ToString(), Text = m.FacName }).ToList();
            dpm.Departments = dept;
            return View(dpm);
        }
        [HttpPost]
        public ActionResult CreateNewDepartment(DepartmentMDV dept, int FacId=1)
        {
         
            ViewBag.Message = null;
            ViewBag.Signal = null;
            var d = dept.Department;
            SystemSpecificRules bll = new SystemSpecificRules();
            var response= bll.CreateDepartment(d);
            ViewBag.Message = response.Message;
            if (response.Response == ResponseCode.OK)
            {
                //dept.Departments = response.Result;
                ViewBag.Signal = "success";
            }
            else
            {
                
                ViewBag.Signal = "error";
            }
            dept.Departments = bll.GetAllDepartments(FacId);
            dept.Faculties = bll.GetAllFaculties().Select(m => new SelectListItem() { Value = m.Id.ToString(), Text = m.FacName }).ToList();
            return View(dept);

        }
        
    }
}