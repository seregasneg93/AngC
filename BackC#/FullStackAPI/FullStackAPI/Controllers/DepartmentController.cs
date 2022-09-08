using FullStackAPI.Data;
using FullStackAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FullStackAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : Controller
    {

        private readonly FullstackDbContext _fullstackDbContext;

        public DepartmentController(FullstackDbContext fullstackDbContext)
        {
            _fullstackDbContext = fullstackDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDepartments()
        {
            List<Department> employeeList = await _fullstackDbContext.Departments
                                                                        .Include(x=>x.Employees)
                                                                        .ToListAsync();
            return Ok(employeeList);
        }
    }
}
