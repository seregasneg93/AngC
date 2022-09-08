using ApllTeleofisBack.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApllTeleofisBack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TerminalController : Controller
    {
        private readonly DataContext _dataContext;

        public TerminalController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTerminals([FromBody] string login)
        {
            var validUser = await _dataContext.Users.FirstOrDefaultAsync(x => x.Login == login);

            if(validUser != null)
                return Ok(validUser.Terminals.ToList());
            else
                return NotFound();
        }
    }
}
