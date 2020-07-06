using EmployeeStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeStore.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly List<Employee> employees;

        public EmployeeController()
        {
            employees = new List<Employee>();
            employees.Add(new Employee() { Id = 1, FirstName = "Vishnu", LastName = "Prasad", Gender = "Male" });
        }

        public ActionResult Index()
        {
            return View(employees);
        }
    }
}