using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZFighters.Models;

namespace ZFighters.Controllers
{
    public class FighterController : Controller
    {
      ApplicationDbContext context;
        public FighterController()
        {
           context = new ApplicationDbContext();
        }

        // GET: Fighter
        public ActionResult Index()
        {
           IEnumerable<Fighter> fighters = context.Fighters;


            return View(fighters);
        }

        // GET: Fighter/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Fighter/Create
        public ActionResult Create()
        {
            Fighter fighter = new Fighter();
            return View(fighter);
        }

        // POST: Fighter/Create
        [HttpPost]
        public ActionResult Create(Fighter fighter)
        {
            try
            {
                // TODO: Add insert logic here
                context.Fighters.Add(fighter);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Fighter/Edit/5
        public ActionResult Edit(int id, string name)
        {
            return View();
        }

        // POST: Fighter/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Fighter/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Fighter/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
