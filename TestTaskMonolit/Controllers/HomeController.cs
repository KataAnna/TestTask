using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestTaskMonolit.Models;

namespace TestTaskMonolit.Controllers
{
    public class HomeController : Controller
    {
        ProjectContext db = new ProjectContext();
        public ActionResult Index()
        {
            return View(db.Programmers.ToList());
        }

        public ActionResult MakeOrder(int? id)
        {
            if (id == null)
                return new HttpNotFoundResult();
            Programmer programmers = db.Programmers.Find(id);
            if (programmers == null)
                return new HttpNotFoundResult();
            OrderViewModel orderModel = new OrderViewModel { ProgrammerId = programmers.Id };
            return View(orderModel);
        }
        [HttpPost]
        public ActionResult MakeOrder(OrderViewModel orderModel)
        {
            if (ModelState.IsValid)
            {
                Programmer programmers = db.Programmers.Find(orderModel.ProgrammerId);
                if (programmers == null)
                    return new HttpNotFoundResult();
               // string workerName = programmers.LastName;

                Project projects = new Project
                {
                    ProgrammerId = programmers.Id,
                    LastName=orderModel.LastName,
                    ProjectName=orderModel.ProjectName,
                    Id=orderModel.ProjectId
                };
                db.Projects.Add(projects);
                db.SaveChanges();
                return Content("<h2>Worker Sucessfully Find</h2>");
            }
            return View(orderModel);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }


        ////public IActionResult Index()
        ////{
        ////    return View();
        ////}

        ////public IActionResult Privacy()
        ////{
        ////    return View();
        ////}

        ////[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        ////public IActionResult Error()
        ////{
        ////    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        ////}
    }
}
