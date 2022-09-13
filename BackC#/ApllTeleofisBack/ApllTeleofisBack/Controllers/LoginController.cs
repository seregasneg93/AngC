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

        //[HttpGet]
        //[Route("{validLogin}/{validPassword}")]
        //public async Task<IActionResult> GetLoginG([FromRoute] string validLogin, [FromRoute] string validPassword) // 
        //{
        //    string logins = validLogin;
        //    string password = "";
        //    var validUser = await _dataContext.Users.FirstOrDefaultAsync(x => x.Login == validLogin && x.Password == validPassword);

        //    if (validUser != null)
        //        return Ok(true);
        //    else
        //        return Ok(false);
        //}

        [HttpGet]
        public async Task<IActionResult> GetLoginG([FromQuery]string validLogin, [FromQuery] string validPassword) // 
        {
            string logins = validLogin;
            //string password = "";
            //var validUser = await _dataContext.Users.FirstOrDefaultAsync(x => x.Login == validLogin && x.Password == validPassword);

            //  if (validUser != null)
            //     return Ok(true);
            // else
            return Ok(false);
        }

        [HttpPost]
        public async Task<IActionResult> GetLogin([FromBody] Login login,[FromQuery(Name = "validLogin")] string validLogin) // 
        {
            string logins = validLogin;
            //string password = "";
            var validUser = await _dataContext.Users.FirstOrDefaultAsync(x => x.Login == login.LoginValid && x.Password == login.Password);

            if (validUser != null)
                return Ok(true);
            else 
                return Ok(false);
        }
    }
}
