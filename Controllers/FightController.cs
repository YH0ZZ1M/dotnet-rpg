using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Dtos.Character.Fight;
using dotnet_rpg.Services.CharacterService.FightService;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("controller")]
    public class FightController : ControllerBase
    {
        //Fields
        private readonly IFightService _fightService;

        //Properties
        public FightController(IFightService fightService)
        {
            _fightService = fightService;
        }

        public async Task<ActionResult<ServiceResponse<AttackResultDto>>> WeaponAttack(WeaponAttackDto request)
        {
            return Ok(await _fightService.WeaponAttack(request));
        }
    }
}