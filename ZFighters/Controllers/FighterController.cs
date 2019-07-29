using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            Fighter fighter = context.Fighters.Where(f => f.Id == id).Single();

            return View(fighter);
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
        public ActionResult Edit(int? id)
        {
            if(id != null)
            {
              Fighter fighter = context.Fighters.Where(f => f.Id == id).Single();
              return View(fighter);
             }
      
            else return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        // POST: Fighter/Edit/5
        [HttpPost]
        public ActionResult Edit(Fighter fighter)
        {
            try
            {
                // TODO: Add update logic here
                Fighter foundFighter = context.Fighters.Find(fighter.Id);
                foundFighter.Name = fighter.Name;
                foundFighter.AlterEgo = fighter.AlterEgo;
                foundFighter.PrimaryAbility = fighter.PrimaryAbility;
                foundFighter.SecondaryAbility = fighter.SecondaryAbility;
                foundFighter.Catchphrase = fighter.Catchphrase;
                context.SaveChanges();
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
            Fighter fighter = context.Fighters.Find(id);
            return View(fighter);
        }

        // POST: Fighter/Delete/5
        [HttpPost]
        public ActionResult Delete(Fighter fighter)
        {
            try
            {
        // TODO: Add delete logic here
                Fighter foundFighter = context.Fighters.Find(fighter.Id);
                context.Fighters.Remove(foundFighter);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
