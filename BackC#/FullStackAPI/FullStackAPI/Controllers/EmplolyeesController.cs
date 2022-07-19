using FullStackAPI.Data;
using FullStackAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FullStackAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmplolyeesController : Controller
    {
        private readonly FullstackDbContext _fullstackDbContext;

        public EmplolyeesController(FullstackDbContext fullstackDbContext)
        {
            _fullstackDbContext = fullstackDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employeeList = await _fullstackDbContext.Employees.ToListAsync();


            return Ok(employeeList);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] Employee employee)
        {
            await _fullstackDbContext.Employees.AddAsync(employee);
            await _fullstackDbContext.SaveChangesAsync();

            return Ok(employee);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetEmployee([FromRoute] string id)
        {
            var employee = await _fullstackDbContext.Employees.FirstOrDefaultAsync(x=>x.Id == Convert.ToInt32(id));

            if (employee is null)
                return NotFound();
            else
                return Ok(employee);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateEmployee([FromRoute]int id,Employee employee)
        {
            var employeeDb = await _fullstackDbContext.Employees.FindAsync(id);

            if (employeeDb is null)
                return NotFound();

            employeeDb.Name = employee.Name;
            employeeDb.Phone = employee.Phone;
            employeeDb.Salary = employee.Salary;
            employeeDb.Email = employee.Email;
            employeeDb.Department = employee.Department;

            await _fullstackDbContext.SaveChangesAsync();

            return Ok(employeeDb);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteEmployee([FromRoute] int id)
        {
            var employeeDb = await _fullstackDbContext.Employees.FindAsync(id);

            if (employeeDb is null)
                return NotFound();

            _fullstackDbContext.Remove(employeeDb);

            await _fullstackDbContext.SaveChangesAsync();

            return Ok(employeeDb);
        }
    }
}
 