using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerceMVC.Service;
using eCommerceMVC.Models;


namespace eCommerceMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Product()
        {
            return View("Product");
        }

        
    }
}