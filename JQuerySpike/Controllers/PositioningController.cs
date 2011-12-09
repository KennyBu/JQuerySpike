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
        public EmptyResult PositionList(List<int> listIds)
        {
            var firstId = listIds.FirstOrDefault();

            return new EmptyResult();
        }

    }
}
