﻿using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;

namespace MvcCv.Controllers
{
    public class SertifikaController : Controller
    {
        // GET: Sertifika
        GenericRepository<TblSertifikalarim> repo= new GenericRepository<TblSertifikalarim> ();
        public ActionResult Index()
        {
            var sertifika = repo.List();
            if (sertifika == null)
            {
                sertifika = new List<TblSertifikalarim>();
            }

            return View(sertifika);
        }
        [HttpGet]
        public ActionResult SertifikaGetir (int id)
        {
            var sertifika =repo.Find(x=> x.ID == id);
            ViewBag.d = id;
            return View(sertifika);
        }
        [HttpPost]
        public ActionResult SertifikaGetir(TblSertifikalarim t)
        {
            var sertifika = repo.Find(x => x.ID == t.ID);
            sertifika.Aciklama= t.Aciklama; 
            sertifika.Tarih= t.Tarih;
            repo.TUpdate(sertifika);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult YeniSertifika()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniSertifika(TblSertifikalarim p)
        {
            repo.TAdd(p);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public ActionResult SertifikaSil(int id)
        {
            var sertifika = repo.Find(x => x.ID == id);
            repo.TDelete(sertifika);
            return RedirectToAction(nameof(Index));
        }
        
    }
}