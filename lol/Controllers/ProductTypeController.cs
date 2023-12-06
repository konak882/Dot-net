using lol.common;
using lol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lol.Controllers
{
    public class ProductTypeController : Controller
    {
        ApplicationDbContext _db;
        public ProductTypeController()
        {
            _db = new ApplicationDbContext();
        }
        
        // GET: ProductType
        [HttpGet]
        public ActionResult Create()
        {
            return View("CreateUpdateForm");
        }
        [HttpPost]
        public ActionResult Create(ProductTypeMst PT)
        {
            _db.ProductTypeMsts.Add(PT);
            _db.SaveChanges();
            return RedirectToAction("ProductTypeList");
        }
        public ActionResult ProductTypeList()
        {
            var prodList = _db.ProductTypeMsts.ToList();
            return View(prodList);
        }
        public ActionResult Edit(int id)
        {
            var productType = _db.ProductTypeMsts.FirstOrDefault(a => a.pk_prodtypeid == id);
            return View("CreateUpdateForm",productType);
        }
    }
} 