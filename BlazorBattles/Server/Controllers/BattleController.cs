using BlazorBattles.Server.Data;
using BlazorBattles.Server.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBattles.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BattleController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IUtilityService _utilityService;

        public BattleController(DataContext context, IUtilityService utilityService)
        {
            _context = context;
            _utilityService = utilityService;
        }

        [HttpPost]
        public async Task<IActionResult> StartBattle([FromBody] int oponentId)
        {
            var attacker = await _utilityService.GetUser();
            var oponent = await _context.Users.FindAsync(oponentId);

            if (oponent == null || oponent.IsDeleted)
            {
                return NotFound("Oponent not available.");
            }

            return Ok();
        }
    } 
}
