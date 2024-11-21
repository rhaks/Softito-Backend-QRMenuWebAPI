using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QRMenuWebAPI.Data;
using QRMenuWebAPI.Models;
using Microsoft.AspNetCore.Identity;

namespace QRMenuWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public RolesController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

       
        // POST: api/Roles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public void PostApplicationRole(string name)
        {

            IdentityRole applicationRole = new IdentityRole(name);
            _roleManager.CreateAsync(applicationRole).Wait();
        }

    }
}
