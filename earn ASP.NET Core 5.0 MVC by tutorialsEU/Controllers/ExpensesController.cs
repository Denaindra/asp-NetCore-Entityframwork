using earn_ASP.NET_Core_5._0_MVC_by_tutorialsEU.Models;
using EFDataAccessLayer.DataAccess;
using EFDataAccessLayer.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace earn_ASP.NET_Core_5._0_MVC_by_tutorialsEU.Controllers
{
    public class ExpensesController : Controller
    {
        private readonly ApplicationDBContext db;
        public ExpensesController(ApplicationDBContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Expense> items = db.Expenses;
            return View(items);
        }

        //GET Action
        public IActionResult Create()
        {
            return View();
        }

        //POST Action
        [HttpPost]
        [ValidateAntiForgeryToken] //validate the toekn that check user alredy exsit
        public IActionResult Create(Expense obj)
        {
            if (ModelState.IsValid)
            {
                db.Expenses.Add(obj);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                var expense = db.Expenses.Find(id);
                db.Remove(expense);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return NotFound();
        }

        public IActionResult Update(int? id)
        {
            if (id != null)
            {
                var expense = db.Expenses.Find(id);
                return View(new ExpensesVM() { ID = expense.ID, Amout = expense.Amout, ExpensesType = expense.ExpensesType });
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(ExpensesVM obj)
        {
            if (obj != null)
            {
                var updatedExpese = new Expense()
                {
                    ID = obj.ID,
                    Amout = obj.Amout,
                    ExpensesType = obj.ExpensesType
                };
                db.Expenses.Update(updatedExpese);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return NotFound();
        }

    }
}
