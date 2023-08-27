using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_Project_API.Identity;

namespace Web_Project_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<IdentityUsers> _userManager;
        public UsersController(UserManager<IdentityUsers> userManager)
        {
            _userManager = userManager;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<IdentityUsers>>> GetUsers()
        {
            if (_userManager.Users == null)
            {
                return NotFound();
            }

            return await _userManager.Users.ToListAsync();
        }
    }
}
