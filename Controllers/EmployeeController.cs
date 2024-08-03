
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        private static readonly List<Employee> employees = new List<Employee>();

        public ActionResult Index()
        {
            return View(employees);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employee.Id = employees.Count + 1;
                employees.Add(employee);
                return RedirectToAction("Index");

            }

                return View(employee);
            }
        }
    }

