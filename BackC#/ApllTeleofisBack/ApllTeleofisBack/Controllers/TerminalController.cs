using ApllTeleofisBack.Data;
using ApllTeleofisBack.Models;
using ApllTeleofisBack.Presenter;
using ApllTeleofisBack.Services;
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
        public async Task<IActionResult> GetAllTerminals([FromQuery] string validLogin)
        {
            ErrorsDB errorsDB = new();

            var validUser = await _dataContext.Users
                        .Include(x => x.Terminals.Where(x=>x.SlaveId > 0))
                            .ThenInclude(x=>x.DataTerminals)
                        .FirstOrDefaultAsync(x => x.Login == validLogin);

            List<VersionFirtware> validVers = await _dataContext.VersionFirtwares
                                                    .Include(x => x.Terminals)
                                                    .ToListAsync();

            List<Terminal> listTerminals = validUser.Terminals.ToList();

            foreach (var terminal in listTerminals)
            {
                foreach (var version in validVers)
                    if (terminal.VersionFirtware.Id == version.Id)
                        terminal.VersionFirtware = version;

                terminal.JournalErrors = await _dataContext.JournalErrors.Where(x => x.Terminal.Id == terminal.Id).ToListAsync();
            }

            List<TerminalPresenter> terminalsPresenter = new List<TerminalPresenter>();

            foreach (var terminal in listTerminals)
            {
                terminalsPresenter.Add(new TerminalPresenter(terminal,
                    errorsDB.ReceiveValidTerminalDataColletions(terminal.DataTerminals.ToList(), terminal.Id,terminal.VersionFirtware.VersionFirtwareTerminal)
                    , errorsDB.ReceiveValidErrorsTerminalColletions(terminal.JournalErrors.ToList(), terminal.Id)));
            }

            if (validUser != null)
                return Ok(terminalsPresenter);
            else
                return NotFound();
        }
    }
}
