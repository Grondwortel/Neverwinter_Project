﻿using System.Linq;
using System.Net;
using System.Web.Mvc;
using Neverwinter.Models;
using System.Data.Entity;
using System.Collections.Generic;

namespace Neverwinter.Controllers
{
    public class CharacterController : Controller
    {
        private NeverwinterContext db = new NeverwinterContext();

        // GET: Character
        public ActionResult Index()
        {
            using (var context = new NeverwinterContext())
            {
                var characters = context.Characters.ToList();
                return View(characters);
            }
        }

        // GET: Character/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var character = db.Characters.Where(c => c.Id == id).FirstOrDefault();
            
            if (character == null)
            {
                return HttpNotFound();
            }
            return View(character);
        }

        // GET: Character/Create
        public ActionResult Create()
        {
            // Race List
            ViewBag.RaceList = (from race in db.Races
                              select new SelectListItem
                              {
                                  Text = race.Name,
                                  Value = race.Id.ToString()
                              }
                  ).ToList();

            // Profession List
            ViewBag.ProfessionList = (from profession in db.Professions
                                   select new SelectListItem
                               {
                                   Text = profession.Name,
                                   Value = profession.Id.ToString()
                             }
                  ).ToList();

            // Gender List
            ViewBag.GenderList = (from gender in db.Genders
                                      select new SelectListItem
                                      {
                                          Text = gender.Name,
                                          Value = gender.Id.ToString()
                                      }
                  ).ToList();

            return View();
        }

        // POST: Character/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Gender,Account,Health,Defense,Attack,Damage,Level,Experience,Power,Toughness,Agility,Knowledge,Profession,Race")] Character character)
        {
            if (ModelState.IsValid)
            {
                db.Characters.Add(character);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(character);
        }

        //// GET: Character/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Character character = db.Characters.Find(id);
        //    if (character == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(character);
        //}

        //// POST: Character/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,Account,Name,Gender,Race,Class,Strength,Constitution,Dexterity,Intelligence,Wisdom,Charisma,Health,Defense,Attack,Damage,Level,Experience")] Character character)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(character).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(character);
        //}

        // GET: Character/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Character character = db.Characters.Find(id);
            if (character == null)
            {
                return HttpNotFound();
            }
            return View(character);
        }

        // POST: Character/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Character character = db.Characters.Find(id);
            db.Characters.Remove(character);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}