using EmpManagement.AppDb;
using Microsoft.AspNetCore.Mvc;

namespace EmpManagement.Controllers
{
    public class EmpManagementController1 : Controller
    {
        private readonly AppDbContext _context;
        public EmpManagementController1(AppDbContext context)
        {
            _context = context;
            
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
