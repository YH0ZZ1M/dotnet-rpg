using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using dotnet_rpg.Services.CharacterService.WeaponService;
using dotnet_rpg.Dtos.Character.Weapon;
using dotnet_rpg.Dtos.Character;

namespace dotnet_rpg.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WeaponController : ControllerBase 
    {
        //Fields
        private readonly IWeaponService _weaponService;

        //Properties
        public WeaponController(IWeaponService weaponService)
        {
            _weaponService = weaponService;
        }

        //Methods
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> AddWeapon(AddWeaponDto newWeapon)
        {
            return Ok(await _weaponService.AddWeapon(newWeapon));
        }
    }
}