using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoEventos.Entidades;

namespace ProjetoEventos.Controllers
{
    [Authorize(AuthenticationSchemes = "CookieAuthentication")]
    public class PermissoesController : Controller
    {
        private readonly Contexto db;

        public PermissoesController(Contexto contexto)
        {
            db = contexto;
        }
        public ActionResult Index()
        {
            return View(db.PERMISSOES.ToList());
        }

        // GET: PermissoesController/Details/5
        public ActionResult Details(int id)
        {
            return View(db.PERMISSOES.Where(a=>a.ID == id).FirstOrDefault());
        }

        // GET: PermissoesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PermissoesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Permissoes collection)
        {
            try
            {
                db.PERMISSOES.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PermissoesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.PERMISSOES.Where(a => a.ID == id).FirstOrDefault());
        }

        // POST: PermissoesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Permissoes collection)
        {
            try
            {
                db.PERMISSOES.Update(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PermissoesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.PERMISSOES.Where(a=>a.ID == id).FirstOrDefault());
        }

        // POST: PermissoesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Permissoes collection)
        {
            try
            {
                db.PERMISSOES.Remove(db.PERMISSOES.Where(a => a.ID == id).FirstOrDefault());
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
