using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;
using ToDo.DAL;
using ToDo.Models;


namespace ToDo.Controllers
{
    public class HomeController : Controller
    {
        private TaskContext db = new TaskContext(); //initialise task context

        public ActionResult Index()
        {
            Task[] tasks = db.Tasks.ToArray(); //retrieve all tasks in db and put them in an array

            return View(tasks); //return the view with tasks
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Details(int? id)
        {

            return RedirectToAction("Details", "TasksController", id);
        }

        public ActionResult Create()
        {
            return RedirectToAction("Create", "Tasks");

        }
    }
}