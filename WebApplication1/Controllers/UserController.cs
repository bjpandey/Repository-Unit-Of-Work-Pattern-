using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.Infrastructure;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        private IUnitOfWork uow = null;
        private UserRepository repo = null;
        public UserController()
        {

            uow = new UnitOfWork();
            repo = new UserRepository(uow);
        }
        public ActionResult Index()
        {
            return View(repo.GetAll());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tblUser tb)
        {
            if (ModelState.IsValid) { 
            int i = repo.Insert(tb);
            return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            tblUser tb = repo.GetAll().Where(u => u.Userid == id).FirstOrDefault();
            return View(tb);
        }
        [HttpPost]
        public ActionResult Edit(tblUser tb)
        {
             repo.Update(tb);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            tblUser tb = repo.GetAll().Where(u => u.Userid == id).FirstOrDefault();
            return View(tb);
        }
        [HttpPost,ActionName("Delete")]
        public ActionResult Delete_post(int id)
        {
            tblUser tb = repo.GetAll().Where(a => a.Userid == id).FirstOrDefault();
            repo.Delete(tb);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            tblUser tb = repo.GetAll().Where(a => a.Userid == id).FirstOrDefault();
            return View(tb);

        }
    }
}