using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JQuerySpike.Controllers
{
    public class PositioningController : Controller
    {
        //
        // GET: /Positioning/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public EmptyResult PositionList(List<int> headerItems, List<int> navigationItems,
            List<int> bodyItems, List<int> footerItems)
        {
            var headerFirstId = headerItems.FirstOrDefault();
            var navigationFirstId = navigationItems.FirstOrDefault();
            var bodyFirstId = bodyItems.FirstOrDefault();
            var footerFirstId = footerItems.FirstOrDefault();

            return new EmptyResult();
        }

    }
}
