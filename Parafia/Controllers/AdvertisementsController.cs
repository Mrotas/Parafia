using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Parafia.Models.Context;
using Parafia.Models.Parafia;


namespace Parafia.Controllers
{
    
    public class AdvertisementsController : Controller
    {
        // GET: Advertisements
        public ActionResult Index()
        {
            return View();
        }

        // GET: Advertisements
        public ActionResult List()
        {
            using (var db = new ParafiaContext())
            {
                return View(db.Ogloszenia.ToList()); 
            }
                
        }

        // GET: Advertisements/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Advertisements/Create
        public ActionResult Create()
        {
            if(Request.IsAuthenticated)
                {
                ViewBag.KsiadzId = System.Web.HttpContext.Current.Session["UserId"];
                return View();
            } else {
                return RedirectToAction("Login", "Login");
            }
        }

        // POST: Advertisements/Create
        [HttpPost]
        public ActionResult Create(Ogloszenie model, HttpPostedFileBase file)
        {
            try
            {
                var db = new ParafiaContext();
         
                //db.Ogloszenia.Add(new Ogloszenie { KsiadzId = collection["KsiadzId"], Tytul = collection["Tytul"], Tresc = collection["Tresc"], Zdjecie = collection["Zdjecie"] });
                // TODO: Add insert logic here
                if (file != null)
                {
                    var originalFilename = Path.GetFileName(file.FileName);
                    string extension = Path.GetExtension(file.FileName);
                    string fileId = Guid.NewGuid().ToString().Replace("-", "") + extension;
                    var path = Path.Combine(Server.MapPath("~/Content/Images/"), fileId);
                    file.SaveAs(path);
                    model.Zdjecie = fileId;
                }
                
                db.Ogloszenia.Add(model);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        // GET: Advertisements/Edit/5
        public ActionResult Edit(int id)
        {
            if (Request.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
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
            if (Request.IsAuthenticated)
            {
                var db = new ParafiaContext();
                Ogloszenie ogl = db.Ogloszenia.Find(id);
                db.Ogloszenia.Remove(ogl);
                db.SaveChanges();
                ViewBag.Removed = "Dane zostały usuniete";
                return RedirectToAction("List");
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
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
