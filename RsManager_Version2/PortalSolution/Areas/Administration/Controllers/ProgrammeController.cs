using DAL;
using ResultBusinessLogic.Implementation;
using ResultBusinessLogic.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalSolution.Areas.Administration.Models
{
    public class ProgrammeController : Controller
    {
        // GET: Administration/Programme
        public ActionResult Index()
        {
            SystemSpecificRules bll = new SystemSpecificRules();
            ProgrammeDMV prog = new Models.ProgrammeDMV();
            prog.Departments = bll.GetAllDepartments().Select(m => new SelectListItem() { Value = m.Id.ToString(), Text = m.DeptFullName }).ToList();
       
            if (prog.Departments != null)
            {
                prog.Programmes = bll.GetProgrammesInDepartment(int.Parse(prog.Departments.FirstOrDefault().Value)).Result;
            }
            else
            {
                prog.Programmes = bll.GetProgrammesInDepartment(1).Result;
            }
            return View(prog);
        }
        [HttpPost]
        public ActionResult Index(int deptId = 1)
        {
            SystemSpecificRules bll = new SystemSpecificRules();
            ProgrammeDMV prog = new ProgrammeDMV();
             prog.Programmes = bll.GetProgrammesInDepartment(deptId).Result;
             prog.Departments = bll.GetAllDepartments().Select(m => new SelectListItem() { Value = m.Id.ToString(), Text = m.DeptFullName }).ToList();

            return View(prog);
        }
        //[HttpPost]
        //public ActionResult ReRopulate(string FacId)
        //{
        //    int facId = int.Parse(FacId);
        //    SystemSpecificRules bll = new SystemSpecificRules();
        //    var dept = bll.GetAllDepartments(facId);

        //    DepartmentMDV dpm = new Models.DepartmentMDV();
        //    dpm.Faculties = bll.GetAllFaculties().Select(m => new SelectListItem() { Value = m.Id.ToString(), Text = m.FacName }).ToList();
        //    dpm.Departments = dept;
        //    return View(dpm);
        //}
        public ActionResult CreateProgramme()
        {
            SystemSpecificRules bll = new SystemSpecificRules();
            ProgrammeDMV progr = new ProgrammeDMV();
            progr.Departments = bll.GetAllDepartments().Select(m => new SelectListItem() { Value = m.Id.ToString(), Text = m.DeptFullName }).ToList();

            return View(progr);
          
        }
        [HttpPost]
        public ActionResult CreateProgramme(ProgrammeDMV programme)
        {
            SystemSpecificRules context = new SystemSpecificRules();
            //ViewBag.msg=
            Programme progr = new Programme();
            progr.DateCreated = DateTime.Now;
            progr.deptId = programme.DeptId;
            progr.ProgrammeCode = programme.ProgrammeCode;
            progr.ProgrammeDescription = programme.ProgrammeDescription;

            var response = context.CreateNewProgramme(progr);
            if(response.Response==ResponseCode.OK)
            {
                ViewBag.flag = 1;
            }
            else
            {
                ViewBag.flag = 0;
            }
            ViewBag.msg = response.Message;

            programme.Departments = context.GetAllDepartments().Select(m => new SelectListItem() { Value = m.Id.ToString(), Text = m.DeptFullName }).ToList();

            return View(programme);
        }
    }
}