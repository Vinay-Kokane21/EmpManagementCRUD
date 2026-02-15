using EmpManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpManagement.AppDb
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
