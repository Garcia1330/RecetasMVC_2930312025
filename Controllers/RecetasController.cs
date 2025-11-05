using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using RecetasMVC_Project.Models;

namespace RecetasMVC_Project.Controllers
{
    public class RecetasController : Controller
    {
        private RecetasContext db = new RecetasContext();

        // GET: Recetas
        public ActionResult Index(string search)
        {
            var q = db.Recetas.AsQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                q = q.Where(r => r.Nombre.Contains(search));
            }
            var list = q.ToList();
            ViewBag.Search = search;
            return View(list);
        }

        // GET: Recetas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var receta = db.Recetas.Find(id);
            if (receta == null) return HttpNotFound();
            return View(receta);
        }

        // GET: Recetas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Recetas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Nombre,Instrucciones,TiempoPreparacion")] Receta receta)
        {
            if (ModelState.IsValid)
            {
                db.Recetas.Add(receta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(receta);
        }

        // GET: Recetas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var receta = db.Recetas.Find(id);
            if (receta == null) return HttpNotFound();
            return View(receta);
        }

        // POST: Recetas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Nombre,Instrucciones,TiempoPreparacion")] Receta receta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(receta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(receta);
        }

        // GET: Recetas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var receta = db.Recetas.Find(id);
            if (receta == null) return HttpNotFound();
            return View(receta);
        }

        // POST: Recetas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            var receta = db.Recetas.Find(id);
            if (receta != null)
            {
                db.Recetas.Remove(receta);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) db.Dispose();
            base.Dispose(disposing);
        }
    }
}
