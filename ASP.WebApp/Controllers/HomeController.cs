﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.DAL;
using ASP.Models;

namespace ASP.Controllers
{
    public class HomeController : Controller
    {
        private AppContext db = new AppContext();

        public ActionResult Index()
        {

            //Employee newEmployee = new Employee { Name = "testemployee", MedicalExamDate = DateTime.Now };

            //db.Employees.Add(newEmployee);
            //db.SaveChanges();

            var employeesList = db.Employees.ToList();

            return View();
        }

    }
}