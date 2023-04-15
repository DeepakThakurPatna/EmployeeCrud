using Microsoft.EntityFrameworkCore;
using WebApplication6.Models;

namespace WebApplication6.Repository
{
    public class EmployeeRepository
    {
        private readonly ApplicationDbContext _db = null;
        public EmployeeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<int> AddNewEmployee(NewEmployeeModel employee)
        {
            var newEmployee = new EmployeeModel()
            {
                Empname=employee.Empname,
                Age = employee.Age,
                Email = employee.Email,
                Salary=employee.Salary

            };
            await _db.EmployeeTable.AddAsync(newEmployee);
            await _db.SaveChangesAsync();
            return newEmployee.Empid;
        }
        public async Task<List<EmployeeModel>> GetAllEmployeeDetails()
        {
            var employeeModels = new List<EmployeeModel>();
            var allEmployee = await _db.EmployeeTable.ToListAsync();
            if (allEmployee ? .Any() == true) 
            {
                foreach (var employee in allEmployee) 
                {
                    employeeModels.Add(new EmployeeModel()
                    {
                        Empname = employee.Empname,
                        Age = employee.Age,
                        Email = employee.Email,
                        Salary = employee.Salary

                    });                
                }
            }
            return employeeModels;
        }
        public async Task<EmployeeModel> GetEmployeeById(int id)
        {
            var employee = await _db.EmployeeTable.FindAsync(id);
            if(employee != null)
            {
                var employeedetails = new EmployeeModel()
                {
                    Empname = employee.Empname,
                    Age = employee.Age,
                    Email = employee.Email,
                    Salary = employee.Salary
                };
                return employeedetails;
            }
            return null;
        }
    }
}
