using ApllTeleofisBack.Data;
using ApllTeleofisBack.Presenter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApllTeleofisBack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        private readonly DataContext _dataContext;

        public LoginController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost]
        public async Task<IActionResult> GetLogin([FromBody] Login login) // 
        {
            //string login = "";
            //string password = "";
            var validUser = await _dataContext.Users.FirstOrDefaultAsync(x => x.Login == login.LoginValid && x.Password == login.Password);

            if (validUser != null)
                return Ok(true);
            else 
                return Ok(false);
        }
    }
}
