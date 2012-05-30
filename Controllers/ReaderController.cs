using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDemo.Models;

namespace MvcDemo.Controllers
{ 
    public class ReaderController : Controller
    {
        private BlogContext db = new BlogContext();

        //
        // GET: /Reader/

        public ViewResult Index()
        {
            return View(db);
        }

        //
        // GET: /Reader/AddComment


        public ActionResult AddComment(int id)
        {
            Comment com = new Comment();
            com.PostId = id;
            com.DateCreated = DateTime.Now;
            return View(com);
        } 

        //
        // POST: /Reader/AddComment

        [HttpPost]
        public ActionResult AddComment(Comment c)
        {
            if (ModelState.IsValid)
            {
                if (ModelState.IsValid)
                {
                   
                    c.DateCreated = DateTime.Now;
                    

                    db.Comments.Add(c);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(c);
        }
        

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}