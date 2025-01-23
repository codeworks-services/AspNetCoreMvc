using AspNetCoreMvcCrud.Biz.Service;
using AspNetCoreMvcCrud.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvcCrud.UI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "View";
            var employees = _employeeService.GetAllEmployees();
            return View(employees);
        }

        public IActionResult Create()
        {
            ViewData["Title"] = "Create";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeService.AddEmployee(employee);
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        public IActionResult Edit(int id)
        {
            ViewData["Title"] = "Edit";
            var employee = _employeeService.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _employeeService.UpdateEmployee(employee);
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        public IActionResult Delete(int id)
        {
            ViewData["Title"] = "Delete";
            var employee = _employeeService.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _employeeService.DeleteEmployee(id);
            return RedirectToAction(nameof(Index));
        }
    }
}