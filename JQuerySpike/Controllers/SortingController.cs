using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using JQuerySpike.Models;

namespace JQuerySpike.Controllers
{
    public class SortingController : Controller
    {
        //
        // GET: /Sorting/

        public ActionResult Index()
        {
            var items = GetItems();
            
            return View(items);
        }

        [HttpPost]
        public EmptyResult SortedLists(List<Guid> listIds)
        {
            SetItems(listIds);

            return new EmptyResult();
        }

        private IEnumerable<ContentItem> GetItems()
        {
            if (Session["sortedList123"] != null)
            {
                return (IEnumerable<ContentItem>) Session["sortedList123"];
            }
            
            var items = new List<ContentItem>
            {
                new ContentItem {Id = Guid.NewGuid(), Description = "Article One"}, 
                new ContentItem {Id = Guid.NewGuid(), Description = "Article Two"}, 
                new ContentItem {Id = Guid.NewGuid(), Description = "Link One"}, 
                new ContentItem {Id = Guid.NewGuid(), Description = "Link Two"}
            };
            Session["sortedList123"] = items;
            return items;
        }

        private void SetItems(IEnumerable<Guid> listIds)
        {
            var items = (List<ContentItem>) Session["sortedList123"];

            var newItems = listIds.Select(id => 
                new ContentItem {Id = id, Description = items.Where(x => x.Id == id).FirstOrDefault().Description}).ToList();

            Session["sortedList123"] = newItems;
        }
    }
}
