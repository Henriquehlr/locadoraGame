using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Locadora.Games.Dados.Entity.Context;
using Locadora.Games.Dominio;

namespace Locadora.Games.Web.Controllers
{
    public class TipoGamesController : Controller
    {
        private GameDBContext db = new GameDBContext();

        // GET: TipoGames
        public ActionResult Index()
        {
            return View(db.TiposGames.ToList());
        }

        // GET: TipoGames/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoGame tipoGame = db.TiposGames.Find(id);
            if (tipoGame == null)
            {
                return HttpNotFound();
            }
            return View(tipoGame);
        }

        // GET: TipoGames/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoGames/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Categoria,Grafico,Classificacao,Descricao,Ano")] TipoGame tipoGame)
        {
            if (ModelState.IsValid)
            {
                db.TiposGames.Add(tipoGame);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoGame);
        }

        // GET: TipoGames/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoGame tipoGame = db.TiposGames.Find(id);
            if (tipoGame == null)
            {
                return HttpNotFound();
            }
            return View(tipoGame);
        }

        // POST: TipoGames/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Categoria,Grafico,Classificacao,Descricao,Ano")] TipoGame tipoGame)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoGame).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoGame);
        }

        // GET: TipoGames/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoGame tipoGame = db.TiposGames.Find(id);
            if (tipoGame == null)
            {
                return HttpNotFound();
            }
            return View(tipoGame);
        }

        // POST: TipoGames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoGame tipoGame = db.TiposGames.Find(id);
            db.TiposGames.Remove(tipoGame);
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
