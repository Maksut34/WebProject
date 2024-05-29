using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Cryptography.X509Certificates;
using Web_BLL.Abstract;
using Web_DTO.Concreate;
using Web_Entity.Models;
using Web_Project.Models;



namespace Web_Project_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoryController : ControllerBase
    {
        private readonly UserManager<Users> _userManager;
        private IAddStoryService _addStoryService;

        public StoryController(IAddStoryService addStoryService, UserManager<Users> userManager)
        {
            _userManager = userManager;
            _addStoryService = addStoryService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AddStory_DAL>>> GetStory()
        {
            var stories = _addStoryService.getAll();  // getAll() metodunu çağırıyoruz.
            if (stories == null)
            {
                return NotFound();
            }

            return Ok(stories);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<AddStory_DAL>> GetStoryID(int id)
        {

            var addStory = await _addStoryService.FindAsync(i => i.AddStoryId == id);

            if (addStory == null)
            {
                return NotFound();
            }
            return Ok(addStory);
        }
        [HttpPost]
        public async Task<ActionResult<AddStory_DAL>> PostStory(AddStoryModels model)
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = await _userManager.Users.FirstOrDefaultAsync(i => i.Name == User.Identity.Name);

                if (user != null)
                {
                    var userStory = await _addStoryService.FindAsync(i => i.UserId == user.Id);
                    if (userStory == null)
                    {
                        AddStory addStory = new AddStory()
                        {
                            UserId = user.Id,
                            storyname = model.storyname,
                            Types = model.Types,
                            Stories = model.Stories
                        };
                         await _addStoryService.AddAsync(addStory);
                    }
                    else
                    {
                        var story = _addStoryService.FindAsync(i => i.storyname == model.storyname && i.Stories == model.Stories);
                        if (story == null)
                        {
                            AddStory addStory = new AddStory()
                            {
                                UserId = user.Id,
                                storyname = model.storyname,
                                Types = model.Types,
                                Stories = model.Stories
                            };
                             await _addStoryService.AddAsync(addStory);
                        }
                    }
                }
            }
            return NoContent();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<AddStory_DAL>> PutStory(AddStoryModels model,int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = await _userManager.Users.FirstOrDefaultAsync(i => i.Name == User.Identity.Name);

                if (user != null)
                {
                    var story = await _addStoryService.FindAsync(i => i.storyname == model.storyname && i.Stories == model.Stories);
                    if (story != null)
                    {
                        if (id == story.AddStoryId)
                        {
                            story.storyname = model.storyname;
                            story.Types = model.Types;
                            story.Stories = model.Stories;

                            await _addStoryService.UpdateAsync(story);
                        }
                        
                    }
                }
            }
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<AddStory_DAL>> DeleteStory(int id)
        {
            if (_addStoryService == null)
            {
                return NotFound();
            }

            var deleteStory = await _addStoryService.FindAsync(i => i.AddStoryId == id);

            if (deleteStory == null)
            {
                return NotFound();
            }
            _addStoryService.DeleteAsync(deleteStory);
            return NoContent();
        }
    }
}
