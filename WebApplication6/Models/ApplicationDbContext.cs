using Microsoft.EntityFrameworkCore;
using WebApplication6.Models;
namespace WebApplication6.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        
        }
        public DbSet<EmployeeModel> EmployeeTable { get; set; }
        public DbSet<WebApplication6.Models.NewEmployeeModel>? NewEmployeeModel { get; set; }
        //public DbSet<WebApplication6.Models.NewEmployeeModel>? NewEmployeeModel { get; set; }
            
    }
}
