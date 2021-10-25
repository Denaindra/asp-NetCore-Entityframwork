using EFDataAccessLayer.DataAccess;
using EFDataAccessLayer.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace earn_ASP.NET_Core_5._0_MVC_by_tutorialsEU.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDBContext db;

        public ItemController(ApplicationDBContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Item> items = db.Items;
            return View(items);
        }

        //GET-Crete
        public IActionResult Create()
        {
            return View();
        }

        //POST-Crete
        [HttpPost]
        [ValidateAntiForgeryToken] //validate the toekn that check user alredy exsit
        public IActionResult Create(Item obj)
        {
            db.Items.Add(obj);
            db.SaveChanges();
            return RedirectToAction("Index");  //invoke the pirticular action method
        }
    }
}
