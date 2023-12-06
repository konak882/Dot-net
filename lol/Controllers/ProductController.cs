using lol.DTO;
using lol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lol.Controllers
{
    public class ProductController : Controller
    {
        ApplicationDbContext _db = new ApplicationDbContext();
        // GET: Product
        [HttpGet]
        public ActionResult AddUpdateProduct()
        {
            var pageLoadData = new ProductMstDTO
            {
                ProductTypeMstList = _db.ProductTypeMsts.ToList()
            };
            return View(pageLoadData);
        }
    }
}