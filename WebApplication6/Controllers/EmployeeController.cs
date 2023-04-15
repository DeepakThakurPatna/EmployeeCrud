using Microsoft.AspNetCore.Mvc;
using WebApplication6.Models;
using WebApplication6.Repository;

namespace WebApplication6.Controllers
{
    public class EmployeeController : Controller
    {
        
        private readonly EmployeeRepository _employeeRepository;

        public EmployeeController(EmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        [HttpGet]
        public ViewResult AddNewEmployee(bool IsSuccess = false)
        {
            ViewBag.IsSuccess = IsSuccess;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewEmployee(NewEmployeeModel employee)
        {
            int id = await _employeeRepository.AddNewEmployee(employee);
            if(id>0) 
            {
                return RedirectToAction(nameof(AddNewEmployee) , new {IsSuccess=true});
            }
            return View();
        }
        public async Task<ViewResult> GetAllEmployee()
        {
            var data = await _employeeRepository.GetAllEmployeeDetails();
            return View(data);
        }
        public async Task<ViewResult> GetEmployeeById(int id)
        {
            var empbyid = await _employeeRepository.GetEmployeeById(id);
            return View(empbyid);
        }
    }
}
