using Microsoft.AspNetCore.Mvc;
using Proje.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Proje.Controllers
{
    public class MovieController : Controller
    {
        private DatabaseContext Context { get; }

        public MovieController(DatabaseContext _context)
        {
            this.Context = _context;
        }

        public IActionResult Movie1()
        {
            List<Comment> commentlist = Context.Comments.ToList();
            return View(commentlist);
        }
        [HttpPost]
        public IActionResult Movie1(string Message)
        {
            Comment comment = new Comment();
            comment.Message = Message;
            comment.CreatedDate = DateTime.Now;
            this.Context.Comments.Add(comment);
            this.Context.SaveChanges();

            List<Comment> commentlist = Context.Comments.ToList();
            return Movie1();
        }
        public IActionResult Movie2()
        {
            return View();
        }
    }
}
