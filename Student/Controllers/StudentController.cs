using Student.Data;
using Student.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student.Controllers
{
    public class StudentController : Controller
    {
        private MyDbContext myDbContext = new MyDbContext();
        // GET: Student
        public ActionResult Index()
        {
            var result = myDbContext.StudentModels.ToList();
            return View(result);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Store(string id, string submissionForm, string money)
        {
            var student = new StudentModel()
            {
                Id = id,
                SubmissionForm = submissionForm,
                Money = money
            };
            myDbContext.StudentModels.Add(student);
            myDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}