using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BLL1;
using BOL;
namespace EComWFE.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Product()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string Email, string Password, string returnUrl)
        {
            if (Admin.ValidateAdmin(Email, Password))
            {
                // return   this.RedirectToAction("index", "products");
                FormsAuthentication.SetAuthCookie(Email, false);
                return Redirect(returnUrl ?? Url.Action("Product", "Admin"));//(actionMethod,controller)
            }
            else
            {
                return View();
            }
        }
            public ActionResult Register()
            {
                return View();
            }
        [HttpPost]
            public ActionResult Register(AdminBOL admin, string returnUrl)
            {
            if(Admin.RegisterAdmin(admin))
            {
                return Redirect(returnUrl ?? Url.Action("Login", "Admin"));
            }
            else
            {
                return View();
            }
            }
        
    }
  }
