using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MezunBilgiSistemiBitirme.Controllers
{
    public class FakulteController : Controller
    {
        FakulteManager fm = new FakulteManager(new EfFakulteDal());

        public ActionResult Index()
        {
            var FakulteValues = fm.GetList();
            return View(FakulteValues);
        }
        [HttpGet]
        public ActionResult AddFakulte()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddFakulte(Fakulte p)
        {
            FakulteValidator fakulteValidator = new FakulteValidator();
            ValidationResult results = fakulteValidator.Validate(p);
            if (results.IsValid)
            {
                fm.FakulteAdd(p);
                return RedirectToAction("Index");
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

        public ActionResult DeleteFakulte(int id)
        {
            var fakulteValue = fm.GetById(id);
            fm.FakulteDelete(fakulteValue);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateFakulte(int id)
        {
            var fakulteValue=fm.GetById(id);
            return View(fakulteValue);
        }

        [HttpPost]
        public ActionResult UpdateFakulte(Fakulte p)
        {
            fm.FakulteUpdate(p);
            return RedirectToAction("Index");
        }
    }
}