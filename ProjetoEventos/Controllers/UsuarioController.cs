﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoEventos.Entidades;

namespace ProjetoEventos.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly Contexto db;
        public UsuarioController(Contexto contexto)
        {
            db = contexto;
        }
        public ActionResult Index()
        {
            return View(db.USUARIO.ToList());
        }

        // GET: UsuarioController/Details/5
        public ActionResult Details(int id)
        {
            return View(db.USUARIO.Where(a=> a.ID == id).FirstOrDefault());
        }

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Usuario collection)
        {
            try
            {
                db.USUARIO.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.USUARIO.Where(a=>a.ID == id).FirstOrDefault());
        }

        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Usuario collection)
        {
            try
            {
                db.USUARIO.Update(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuarioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.USUARIO.Where(a=> a.ID == id).FirstOrDefault());
        }

        // POST: UsuarioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Usuario collection)
        {
            try
            {
                db.USUARIO.Remove(db.USUARIO.Where(a => a.ID == id).FirstOrDefault());
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
