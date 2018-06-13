using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parafia.Controllers
{
    public class AdvertisementsController : Controller
    {
        // GET: Advertisements
        public ActionResult Index()
        {
            return View();
        }

        // GET: Advertisements/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Advertisements/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Advertisements/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
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

        // GET: Advertisements/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Advertisements/Edit/5
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

        // GET: Advertisements/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Advertisements/Delete/5
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
