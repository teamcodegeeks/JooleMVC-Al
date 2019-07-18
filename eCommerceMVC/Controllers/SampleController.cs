using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eCommerceMVC.Service;
using eCommerceMVC.Models;

namespace eCommerceMVC.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Sample(int _SubcategoryId)
        {
            
            return View("~/Views/Sample/Sample.cshtml");
        }

        public ActionResult Test()
        {
            
            SearchService serc = new SearchService(new JoojleEntities());
            List<ProductSubCategory> cata = serc.GetSubCategoryWOCache();
            
            List<string> list;
            //List<string> lis2 = cata.ToList();


            //list = cata.Select(s => (string)s).ToList();
            List<int> listsub = new List<int>(cata.Count);
            List<string> listproperty = new List<string>(cata.Count);
            List<int> listmin = new List<int>(cata.Count);
            List<int> listmax = new List<int>(cata.Count);
            for(int i = 0; i < cata.Count; i++)
            {
                listsub.Add(cata[i].CategoryId);
                listproperty.Add(cata[i].SubCategoryName);
                listmin.Add(cata[i].SubCategoryId);
                listmax.Add(cata[i].SubCategoryId);
                
            }
            list = (from o in cata select o.ToString()).ToList();
            var mylist = cata.ConvertAll(x => Convert.ToString(x));
            System.Diagnostics.Debug.WriteLine("--------------------------");
            System.Diagnostics.Debug.WriteLine(cata[0].SubCategoryName);
            System.Diagnostics.Debug.WriteLine(mylist[0]);
            System.Diagnostics.Debug.WriteLine(list[0]);
            System.Diagnostics.Debug.WriteLine("--------------------------");
            ViewBag.obj = list;

            ViewBag.sub = listsub;
            ViewBag.name = listproperty;
            ViewBag.min = listmin;
            ViewBag.max = listmax;

            return View();
        }
    }
}