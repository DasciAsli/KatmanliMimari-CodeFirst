using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AD_DenemeKatmanli_BLL.Concrete;
using AD_DenemeKatmanli_DAL.Concrete;
using AD_DenemeKatmanli_Entities.Model;

namespace AD_DenemeKatmanli_Presentation.Areas.ManagementPanel.Controllers
{
    public class RolesController : Controller
    {
        private Context db = new Context();
        RoleManager rmanager = new RoleManager(new EFRolesDAL());

        // GET: ManagementPanel/Roles
        public ActionResult Index()
        {
            return View(rmanager.GetAll());
        }

        // GET: ManagementPanel/Roles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Roles roles = db.Roles.Find(id);
            var model = rmanager.Get(id.Value);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // GET: ManagementPanel/Roles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManagementPanel/Roles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RoleId,RoleName")] Roles roles)
        {
            if (ModelState.IsValid)
            {
                //db.Roles.Add(roles);
                //db.SaveChanges();
                rmanager.Add(roles);
                return RedirectToAction("Index");
            }

            return View(roles);
        }

        // GET: ManagementPanel/Roles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Roles roles = db.Roles.Find(id);
            var model = rmanager.Get(id.Value);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: ManagementPanel/Roles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RoleId,RoleName")] Roles roles)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(roles).State = EntityState.Modified;
                //db.SaveChanges();
                rmanager.Update(roles);
                return RedirectToAction("Index");
            }
            return View(roles);
        }

        // GET: ManagementPanel/Roles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Roles roles = db.Roles.Find(id);
            var model = rmanager.Get(id.Value);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: ManagementPanel/Roles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Roles roles = db.Roles.Find(id);
            //db.Roles.Remove(roles);
            //db.SaveChanges();
            var model = rmanager.Get(id);
            rmanager.Delete(model);
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
