using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_BLL.Abstract;
using Web_Entity.Models;

namespace Web_Project_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Player_ValuesController : ControllerBase
    {
        private readonly IPlayerValues_Service _playerValuesService;
        
        public Player_ValuesController(IPlayerValues_Service playerValues_Service)
        {
            _playerValuesService=playerValues_Service;
        }
        [HttpGet("getvalues/{userid}")]
        public async Task<ActionResult<Player_Values>> getvaluesID(int userid)
        {
            var playervalues = await _playerValuesService.FindAsync(i => i.UserId == userid);

            if (playervalues == null)
            {
                return NotFound();
            }
            return Ok(playervalues);
        }
        [HttpPut("UpdatePlayerHealth/{id}/{damage}")]
        public async Task<IActionResult> UpdatePlayerHealth(int id, float damage)
        {

            var playervalues = await _playerValuesService.FindAsync(i => i.UserId == id);

            if (playervalues == null)
            {
                return NotFound();
            }

            if(playervalues.player_Health<=0)
            {
                playervalues.player_Health = 0;
            }
            if (playervalues.player_Health > 0)
            {
                playervalues.player_Health -= damage;
            }

            try
            {
                // Veritabanında güncelleme işlemini gerçekleştir
                await _playerValuesService.UpdateAsync(playervalues);
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(500, "Kullanıcı durumu güncelleme işlemi başarısız oldu.");
            }

            return NoContent();
        }
    }
}
