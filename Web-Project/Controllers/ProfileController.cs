using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
<<<<<<< HEAD
using Web_BLL.Abstract;
using Web_DTO.DTO.UsersLoginDTO;
=======
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
using Web_Entity.Models;

namespace Web_Project.Controllers
{
<<<<<<< HEAD
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly UserManager<Users> _user;
        private readonly IUsers_InformationService _usersInformationService;
        private readonly IImageService _imageService;
        private readonly IAddStoryService _addStoryService;
        public ProfileController(UserManager<Users> user,IUsers_InformationService users_InformationService, IImageService ımageService, IAddStoryService addStoryService) 
        {
            _user = user;
            _usersInformationService = users_InformationService;
            _imageService = ımageService;
            _addStoryService = addStoryService;
        }
        [HttpGet]
=======
    public class ProfileController : Controller
    {
        private readonly UserManager<Users> _user;
        public ProfileController(UserManager<Users> user) 
        {
            _user = user;
        }
        [Authorize]
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
        public async Task<IActionResult> Profile()
        {
            if (User.Identity.IsAuthenticated)
            {
<<<<<<< HEAD
                var userr=await _user.FindByNameAsync(User.Identity.Name);
                if (userr != null)
                {

                    UsersLoginDTO usersLoginDTO = new UsersLoginDTO();
                    ViewBag.name = userr.Name;
                    ViewBag.surname = userr.Surname;
                    ViewBag.Username = userr.UserName;
                    ViewBag.email = userr.Email;

                    Users_İnformation users_İnformation=new Users_İnformation();
                    var informationID = await _usersInformationService.FindAsync(i => i.UserId == userr.Id);

                    if(informationID != null)
                    {
                        ViewBag.address = informationID.Address;
                        ViewBag.city = informationID.City;
                        ViewBag.country = informationID.Country;

                        if(User.Identity.IsAuthenticated)
                        {
                            var use = await _user.FindByNameAsync(User.Identity.Name);
                            if (use != null)
                            {
                                var img = _imageService.getAll().Where(i => i.UserId == use.Id);
                                var story = _addStoryService.getAll().Where(i => i.UserId == use.Id);

                                if (img != null && story != null)
                                {
                                    ViewBag.Images = img
                                        .Where(i => !string.IsNullOrEmpty(i.image))
                                        .Take(5)
                                        .ToList();

                                    ViewBag.addStories = story
                                        .Where(i => !string.IsNullOrEmpty(i.storyname) && !string.IsNullOrEmpty(i.Types) && !string.IsNullOrEmpty(i.Stories))
                                        .Take(5)
                                        .ToList();
                                }
                                return View();
                            }
                            
                        }
                    }
                }
            }

=======
                ModelState.AddModelError("", "Kullanıcı aktif!");
            }
            else
            {
                ModelState.AddModelError("", "Kullanıcı aktif değil!");
            }
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
            return View();
        }
    }
}
