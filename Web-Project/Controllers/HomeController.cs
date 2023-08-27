
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using Web_BLL.Abstract;
using Web_DTO.DTO.UsersLoginDTO;
using Web_Entity.Models;
using Web_Project.Models;

namespace Web_Project.Controllers
{
    public class HomeController : Controller
    {

        private readonly UserManager<Users> _usermanager;
        
        private readonly IAddStoryService _addStoryService;

        private readonly IContect_Service _contect_Service;
       
        public HomeController(UserManager<Users> userManager,IAddStoryService addStoryService,
          IContect_Service contect_Service)
        {
            _usermanager = userManager;

            _contect_Service = contect_Service;
           
            _addStoryService = addStoryService;

        }
        public IActionResult Keşfet()
        {
            return View();
        }
        [Authorize]
        [HttpGet]
        public IActionResult AnaSayfa()
        {

            var stor = _addStoryService.getAll().ToList();



            return View(new UsersLoginDTO
            {
                addStories = stor.Take(10).ToList()
            });
            
        }
        [Authorize]
        public IActionResult About()
        {
            return View();
        }
        [Authorize]
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
        
        [HttpPost]
        public async Task <IActionResult> Contact(UsersLoginDTO usersLoginDTO)
        {

            if(User.Identity.IsAuthenticated)
            {
                var user= await _usermanager.FindByNameAsync(User.Identity.Name);

                if(user != null && usersLoginDTO.email == user.Email)
                {

                    Contact c = new Contact()
                    {
                        email = usersLoginDTO.email,
                        message = usersLoginDTO.message,
                        UserID = user.Id
                    };

                    _contect_Service.Insert(c);

                }
            }

            return RedirectToAction("Profile", "Profile");
        }

    }
}