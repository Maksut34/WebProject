using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Web_BLL.Abstract;
using Web_Entity.Models;
using Web_Project.Models;

namespace Web_Project.Controllers
{
    public class AddStoryController : Controller
    {
        private readonly UserManager<Users> _userManager;

        private readonly IAddStoryService _addStoryService;

        public AddStoryController(UserManager<Users> userManager, IAddStoryService addStoryService)
        {
            _userManager = userManager;
            _addStoryService = addStoryService;
        }

        [HttpGet]
        public IActionResult AddStory()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> AddStory( AddStoryModels model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (user != null)
            {
               var story=_addStoryService.Find(i=>i.storyname== model.storyname&&i.Stories==model.Stories);

                if (story != null)
                {
                    ModelState.AddModelError("", "Başlık veya hikaye zaten mevcut!");
                }
                else
                {
                    var addStory = new AddStory
                    {
                        UserId = user.Id,
                        storyname = model.storyname,
                        Types = model.Types,
                        Stories = model.Stories
                    };

                    if (ModelState.IsValid)
                    {
                        _addStoryService.Insert(addStory);

                        return RedirectToAction("Profile", "Profile");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Bütün alanlar zorunludur!");
                    }
                }
            }
            return View();

        }   
        
        
    }
}
