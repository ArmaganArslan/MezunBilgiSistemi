using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FluentValidation.Results;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace MezunBilgiSistemiBitirme.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        AdminManager adm = new AdminManager(new EfAdminDal());
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult GetAdminList()
        {
            var adminvalues = adm.GetList();
            return View(adminvalues);
        }

        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAdmin(Admin p)
        {
            AdminValidator adminValidator = new AdminValidator();
            ValidationResult results = adminValidator.Validate(p);
            if (results.IsValid)
            {
                adm.AdminAdd(p);
                return RedirectToAction("GetAdminList");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();

        }
    }
}