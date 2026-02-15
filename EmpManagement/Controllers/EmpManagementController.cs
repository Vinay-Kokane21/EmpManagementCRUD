using EmpManagement.AppDb;
using EmpManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmpManagement.Controllers
{
    public class EmpManagementController : Controller
    {
        private readonly AppDbContext _context;
        public EmpManagementController(AppDbContext context)
        {
            _context = context;
            
        }
        //Read
        public IActionResult Index()
        {
            List<Employee> emp = _context.Employees.ToList();
            return View(emp);
        }

        //Create

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            if(ModelState.IsValid)
            {
                _context.Employees.Add(emp);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        //Update
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if(id == null && id == 0)
            {
                return NotFound("Not Found");
            }

            Employee? emp = _context.Employees.Find(id);
            if(emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }

        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
            if(ModelState.IsValid)
            {
                _context.Employees.Update(emp);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        //Delete
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null && id == 0)
            {
                return NotFound("Not Found");
            }

            Employee? emp = _context.Employees.Find(id);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }

        [HttpPost]
        public IActionResult Delete(Employee emp)
        {
            _context.Employees.Remove(emp);
            _context.SaveChanges();
            return RedirectToAction("Index");
                     
        }
    }
}
