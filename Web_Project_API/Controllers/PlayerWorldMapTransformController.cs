using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_BLL.Abstract;
using Web_Entity.Models;

namespace Web_Project_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PlayerWorldMapTransformController : ControllerBase
    {
        private readonly IPlayerWorldMapTransformService _playerWorldMapTransformService;
        
        public PlayerWorldMapTransformController(IPlayerWorldMapTransformService playerWorldMapTransformService)
        {
            _playerWorldMapTransformService = playerWorldMapTransformService;
        }

        [HttpGet("GetbyID/{id}")]
        public async Task<ActionResult<PlayerWorldMapTransform>> GetbyID(int id)
        {
            var worldMapLastTransform = await _playerWorldMapTransformService.FindAsync(i => i.UserId == id);

            if (worldMapLastTransform == null)
            {
                return NotFound();
            }
            return Ok(worldMapLastTransform);

        }

        [HttpPut("ActivateworldMaptransformIsHome/{id}")]
        public async Task<IActionResult> ActivateworldMaptransformIsHome(int id)
        {

            var WorlMaptransform = await _playerWorldMapTransformService.FindAsync(i => i.UserId == id);

            if (WorlMaptransform == null)
            {
                return NotFound();
            }

            // Kullanıcının durumunu güncelle
            WorlMaptransform.worlMaptransformIsHome = true;
            WorlMaptransform.worlMaptransformIsLittleForest = false;
            WorlMaptransform.worlMaptransformIsTown = false;
            try
            {
                // Veritabanında güncelleme işlemini gerçekleştir
                await _playerWorldMapTransformService.UpdateAsync(WorlMaptransform);
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(500, "Bölgeye ilerlenemedi.");
            }

            return NoContent();
        }
        [HttpPut("ActivateWorldMapTransformIsLittleForest/{id}")]
        public async Task<IActionResult> ActivateWorldMapTransformIsLittleForest(int id)
        {
            var worldMapTransform = await _playerWorldMapTransformService.FindAsync(i => i.UserId == id);

            if (worldMapTransform == null)
            {
                return NotFound();
            }

            // Kullanıcının durumunu güncelle
            worldMapTransform.worlMaptransformIsHome = false;
            worldMapTransform.worlMaptransformIsLittleForest = true;
            worldMapTransform.worlMaptransformIsTown = false;

            try
            {
                // Veritabanında güncelleme işlemini gerçekleştir
                await _playerWorldMapTransformService.UpdateAsync(worldMapTransform);
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(500, "Bölgeye ilerlenemedi.");
            }

            return NoContent();
        }
        [HttpPut("ActivateworldMaptransformIsTown/{id}")]
        public async Task<IActionResult> ActivateworldMaptransformIsTown(int id)
        {

            var WorlMaptransform = await _playerWorldMapTransformService.FindAsync(i => i.UserId == id);

            if (WorlMaptransform == null)
            {
                return NotFound();
            }

            // Kullanıcının durumunu güncelle
            WorlMaptransform.worlMaptransformIsHome = false;
            WorlMaptransform.worlMaptransformIsLittleForest = false;
            WorlMaptransform.worlMaptransformIsTown = true;
            try
            {
                // Veritabanında güncelleme işlemini gerçekleştir
                await _playerWorldMapTransformService.UpdateAsync(WorlMaptransform);
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(500, "Bölgeye ilerlenemedi.");
            }

            return NoContent();
        }
        
    }
}
