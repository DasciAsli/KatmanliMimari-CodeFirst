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
    public class UsersController : Controller
    {
        private Context db = new Context();
        UserManager umanager = new UserManager(new EFUsersDAL());
        RoleManager rmanager = new RoleManager(new EFRolesDAL());
        // GET: ManagementPanel/Users
        public ActionResult Index()
        {
            //var users = db.Users.Include(u => u.Roles);
            //return View(users.ToList());
            return View(umanager.GetAll());
        }

        // GET: ManagementPanel/Users/Details/5
        public ActionResult Details(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //Users users = db.Users.Find(id);
            //if (users == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(users);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var model = umanager.GetDetails(id.Value);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);

        }

        // GET: ManagementPanel/Users/Create
        public ActionResult Create()
        {
            //ViewBag.RoleId = new SelectList(db.Roles, "RoleId", "RoleName");
            ViewBag.RoleId = new SelectList(rmanager.GetAll(), "RoleId", "RoleName");
            return View();
        }

        // POST: ManagementPanel/Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserId,UserName,UserSurname,Email,Password,RoleId")] Users users)
        {
            if (ModelState.IsValid)
            {
                //db.Users.Add(users);
                //db.SaveChanges();
                umanager.Add(users);
                return RedirectToAction("Index");
            }

            ViewBag.RoleId = new SelectList(rmanager.GetAll(), "RoleId", "RoleName", users.RoleId);
            return View(users);
        }

        // GET: ManagementPanel/Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Users users = db.Users.Find(id);
            var model = umanager.GetDetails(id.Value);
            if (model == null)
            {
                return HttpNotFound();
            }
            ViewBag.RoleId = new SelectList(rmanager.GetAll(), "RoleId", "RoleName", model.RoleId);
            return View(model);
        }

        // POST: ManagementPanel/Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserId,UserName,UserSurname,Email,Password,RoleId")] Users users)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(users).State = EntityState.Modified;
                //db.SaveChanges();
                umanager.Update(users);
                return RedirectToAction("Index");
            }
            ViewBag.RoleId = new SelectList(rmanager.GetAll(), "RoleId", "RoleName", users.RoleId);
            return View(users);
        }

        // GET: ManagementPanel/Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Users users = db.Users.Find(id);
            var model = umanager.GetDetails(id.Value);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        // POST: ManagementPanel/Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Users users = db.Users.Find(id);
            //db.Users.Remove(users);
            var model = umanager.Get(id);
            umanager.Delete(model);
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
