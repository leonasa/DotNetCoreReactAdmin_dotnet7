using DotNetCoreReactAdmin_dotnet7.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreReactAdmin_dotnet7.Controllers
{
    [ApiExplorerSettings(GroupName = "Migrations")]
    [Route("api/ApplyDatabaseMigrations")]
    [ApiController]
    public class MigrationController : ControllerBase
    {
        protected readonly DotNetCoreReactAdminContext _context;

        public MigrationController(DotNetCoreReactAdminContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            await _context.Database.MigrateAsync();
            return Ok();
        }
    }
}
