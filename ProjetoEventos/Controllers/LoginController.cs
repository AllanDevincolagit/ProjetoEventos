using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoEventos.Entidades;

namespace ProjetoEventos.Controllers
{
    public class LoginController : Controller
    {
        private readonly Contexto db;
        public LoginController(Contexto contexto)
        {
            db = contexto;
        }
        public ActionResult Index()
        {
            return View(db.LOGIN.ToList());
        }

        // GET: LoginController/Details/5
        public ActionResult Details(int id)
        {
            return View(db.LOGIN.Where(a=> a.Id == id).FirstOrDefault());
        }

        // GET: LoginController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Login collection)
        {
            try
            {
                db.LOGIN.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.LOGIN.Where(a=> a.Id == id).FirstOrDefault());
        }

        // POST: LoginController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Login collection)
        {
            try
            {
                db.LOGIN.Update(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.LOGIN.Where(a=>a.Id == id).FirstOrDefault());
        }

        // POST: LoginController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Login collection)
        {
            try
            {
                db.LOGIN.Remove(db.LOGIN.Where(a => a.Id == id).FirstOrDefault());
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
