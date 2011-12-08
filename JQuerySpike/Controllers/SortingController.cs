using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JQuerySpike.Controllers
{
    public class SortingController : Controller
    {
        //
        // GET: /Sorting/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public EmptyResult Index(List<int> listIds)
        {
            var firstId = listIds.FirstOrDefault();

            return new EmptyResult();
        }

    }
}
