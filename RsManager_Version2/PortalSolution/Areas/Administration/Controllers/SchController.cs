using PortalSolution.Areas.Administration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalSolution.Areas.Administration.Controllers
{
    public class SchController : Controller
    {
        // GET: Administration/Sch
        public ActionResult Index()
        {
            return View();
        }

        // GET: Administration/Sch/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Administration/Sch/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administration/Sch/Create
        [HttpPost]
        public ActionResult Create(SchoolMDV sDMV)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Administration/Sch/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Administration/Sch/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Administration/Sch/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Administration/Sch/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
