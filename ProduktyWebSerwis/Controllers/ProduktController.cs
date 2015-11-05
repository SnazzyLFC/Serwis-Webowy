﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProduktyWebSerwis.Models;
using ProduktyWebSerwis.Repo;
using ProduktyWebSerwis.Repo.IRepo;

namespace ProduktyWebSerwis.Controllers
{
    public class ProduktController : Controller
    {
        public ProduktController(IProduktRepo repo)
        {
            _repo = repo;
        }
        private readonly IProduktRepo _repo;       
        
        // GET: Produkt
        public ActionResult Index()
        {
            var produkty = _repo.PobierzProdukty();
            return View(produkty);
        }

        //// GET: Produkt/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Produkt produkt = db.Produkty.Find(id);
        //    if (produkt == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(produkt);
        //}

        //// GET: Produkt/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Produkt/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,Nazwa")] Produkt produkt)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Produkty.Add(produkt);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(produkt);
        //}

        //// GET: Produkt/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Produkt produkt = db.Produkty.Find(id);
        //    if (produkt == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(produkt);
        //}

        //// POST: Produkt/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,Nazwa")] Produkt produkt)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(produkt).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(produkt);
        //}

        //// GET: Produkt/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Produkt produkt = db.Produkty.Find(id);
        //    if (produkt == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(produkt);
        //}

        //// POST: Produkt/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Produkt produkt = db.Produkty.Find(id);
        //    db.Produkty.Remove(produkt);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
