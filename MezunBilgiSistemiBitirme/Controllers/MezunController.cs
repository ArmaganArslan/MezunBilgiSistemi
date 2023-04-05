using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace MezunBilgiSistemiBitirme.Controllers
{
    public class MezunController : Controller
    {
        MezunManager mm = new MezunManager(new EfMezunDal());
        BolumManager bm = new BolumManager(new EfBolumDal());
        FakulteManager fm = new FakulteManager(new EfFakulteDal());

        public ActionResult Index()
        {
            var MezunValues = mm.GetList();
            return View(MezunValues);
        }
        public ActionResult Home()
        {
            var MezunValues = mm.GetList();
            var BolumValues = bm.GetList();
            var FakulteValues = fm.GetList();
            return View(MezunValues);
            return View(BolumValues);
            return View(FakulteValues);
        }
        [HttpGet]
        public ActionResult AddMezun()
        {
            
            List<SelectListItem> valueBolum = (from x in bm.GetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.ad,
                                                     Value = x.bolumId.ToString(),
                                                 }).ToList();
            ViewBag.vlb = valueBolum;
                
            return View();
        }
        [HttpPost]
        public ActionResult AddMezun(Mezun p)
        {
            MezunValidator mezunValidator = new MezunValidator();
            ValidationResult results = mezunValidator.Validate(p);
            if (results.IsValid)
            {
                mm.MezunAdd(p);
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
        public ActionResult DeleteMezun(int id)
        {
            var mezunValue = mm.GetById(id);
            mm.MezunDelete(mezunValue);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateMezun(int id)
        {

            List<SelectListItem> valueBolum = (from x in bm.GetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.ad,
                                                   Value = x.bolumId.ToString(),
                                               }).ToList();
            ViewBag.vlb = valueBolum;

            var mezunValue = mm.GetById(id);
            return View(mezunValue);
        }

        [HttpPost]
        public ActionResult UpdateMezun(Mezun p)
        {
            mm.MezunUpdate(p);
            return RedirectToAction("Index");
        }
    }
}