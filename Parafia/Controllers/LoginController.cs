using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Parafia.Models.Context;
using Parafia.Models.Parafia;

namespace Parafia.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login login, string returnUrl = "")
        {
            using (var db = new ParafiaContext())
            {
                Uzytkownicy user = db.Uzytkownicy.FirstOrDefault(x => x.Email == login.Email);
                if (user != null)
                {
                    if (String.CompareOrdinal(login.Password, user.Haslo) == 0)
                    {
                        int credentialsExpiration = login.RememberMe ? 525000 : 1440;
                        var ticket = new FormsAuthenticationTicket(login.Email, login.RememberMe, credentialsExpiration);
                        string encrypted = FormsAuthentication.Encrypt(ticket);
                        var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encrypted);
                        cookie.Expires = DateTime.Now.AddMinutes(credentialsExpiration);
                        cookie.HttpOnly = true;
                        Response.Cookies.Add(cookie);
                        Session["UserId"] = user.Id;
                        Session["Name"] = user.Imie;

                        return RedirectToAction("Index", "Home");
                    }
                }
            }

            ViewBag.Message = "Niepoprawny login lub hasło.";
            return View();
        }

        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}