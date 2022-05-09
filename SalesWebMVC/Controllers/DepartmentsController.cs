using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> departments = new List<Department>();

            departments.Add(new Department() { Id = 1, Name = "Pedro" });
            departments.Add(new Department() { Id = 2, Name = "Radassa" });
            departments.Add(new Department() { Id = 3, Name = "nelio" });

            return View(departments);
        }
    }
}
