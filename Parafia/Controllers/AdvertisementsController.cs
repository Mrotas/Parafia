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
            using (var db = new ParafiaContext())
            {
                return View(db.Ogloszenia.ToList());
            }
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
            var db = new ParafiaContext();
            Ogloszenie ogl = db.Ogloszenia.Find(id);
            return View(ogl);
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
        [ValidateInput(false)]
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
                TempData["OK"] = "Dane zostały zapisane";
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
                var db = new ParafiaContext();
                Ogloszenie ogl = db.Ogloszenia.Find(id);
                return View(ogl);
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        // POST: Advertisements/Edit/5
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult Edit(int id, Ogloszenie model, HttpPostedFileBase file)
        {
            try
            {
                // TODO: Add update logic here
                var db = new ParafiaContext();
                Ogloszenie ogl = db.Ogloszenia.Find(id);
                ogl.KsiadzId = model.KsiadzId;
                ogl.Tytul = model.Tytul;
                ogl.Tylko_Tresc = model.Tylko_Tresc;
                ogl.Tresc = model.Tresc;
                if (file != null)
                {
                    var originalFilename = Path.GetFileName(file.FileName);
                    string extension = Path.GetExtension(file.FileName);
                    string fileId = Guid.NewGuid().ToString().Replace("-", "") + extension;
                    var path = Path.Combine(Server.MapPath("~/Content/Images/"), fileId);
                    file.SaveAs(path);
                    model.Zdjecie = fileId;
                    ogl.Zdjecie = model.Zdjecie;
                }
                
                db.SaveChanges();
                TempData["OK"] = "Edycja poprawna";
                return RedirectToAction("List");
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
                TempData["OK"] = "Dane zostały usuniete";
                return RedirectToAction("List");
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        // GET: Advertisements/Edit/5
        public ActionResult Read(int id)
        {
            if (Request.IsAuthenticated)
            {
                var db = new ParafiaContext();
                Ogloszenie ogl = db.Ogloszenia.Find(id);
                return View(ogl);
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

    }

}
