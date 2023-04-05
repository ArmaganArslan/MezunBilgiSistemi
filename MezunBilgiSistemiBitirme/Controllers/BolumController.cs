using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MezunBilgiSistemiBitirme.Controllers
{
    public class BolumController : Controller
    {
        BolumManager bm = new BolumManager(new EfBolumDal());
        FakulteManager fm = new FakulteManager(new EfFakulteDal());

        public ActionResult Index()
        {
            var BolumValues = bm.GetList();
            return View(BolumValues);
        }
        [HttpGet]
        public ActionResult AddBolum()
        {
            List<SelectListItem> valueFakulte = (from x in fm.GetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.ad,
                                                     Value = x.fakulteId.ToString(),
                                                 }).ToList();
            ViewBag.vlf = valueFakulte;
            return View();
        }
        [HttpPost]
        public ActionResult AddBolum(Bolum p)
        {
            BolumValidator bolumValidator = new BolumValidator();
            ValidationResult results = bolumValidator.Validate(p);
            if (results.IsValid)
            {
                bm.BolumAdd(p);
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
        public ActionResult DeleteBolum(int id)
        {
            var bolumValue = bm.GetById(id);
            bm.BolumDelete(bolumValue);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateBolum(int id)
        {
            List<SelectListItem> valueFakulte = (from x in fm.GetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.ad,
                                                     Value = x.fakulteId.ToString(),
                                                 }).ToList();
            ViewBag.vlf = valueFakulte;
            var bolumValue = bm.GetById(id);
            return View(bolumValue);
        }

        [HttpPost]
        public ActionResult UpdateBolum(Bolum p)
        {
            bm.BolumUpdate(p);
            return RedirectToAction("Index");
        }
    }
}