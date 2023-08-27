using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Web_BLL.Abstract;
using Web_Entity.Models;
using Web_Project.Models;

namespace Web_Project.Controllers
{
    public class UsersProfileController : Controller
    {

        private readonly UserManager<Users> _userManager;
        private readonly IUsers_InformationService _usersInformationService;

        public UsersProfileController(UserManager<Users> userManager,IUsers_InformationService users_InformationService)
        {
            _usersInformationService = users_InformationService;    
            _userManager = userManager;
        }
        //[Authorize]
        [HttpGet]
        public IActionResult Usersİnformation()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Usersİnformation(EditProfileViewModel editProfileViewModel)
        {

            if (User.Identity.IsAuthenticated)
            {
                var userId = await _userManager.FindByNameAsync(User.Identity.Name);
                if (userId != null)
                {
                    Users_İnformation users_İnformation = new Users_İnformation();
                    users_İnformation.Address = editProfileViewModel.Address;
                    users_İnformation.City = editProfileViewModel.City;
                    users_İnformation.Country = editProfileViewModel.Country;
                    users_İnformation.UserId = userId.Id;
                    users_İnformation.Users = new Users();

                    if (ModelState.IsValid)
                    {
                        var informationID = await _usersInformationService.FindAsync(i => i.UserId == users_İnformation.UserId);

                        if (informationID != null && users_İnformation.UserId == userId.Id)
                        {
                            informationID.Address = editProfileViewModel.Address;
                            informationID.City = editProfileViewModel.City;
                            informationID.Country = editProfileViewModel.Country;

                            _usersInformationService.Update(informationID);

                            return RedirectToAction("Profile", "Profile");
                        }
                        else if (informationID == null)
                        {
                            var use = await _userManager.FindByNameAsync(User.Identity.Name);

                            if (use != null)
                            {
                                Users_İnformation user = new Users_İnformation();

                                user.City = editProfileViewModel.City;
                                user.Country = editProfileViewModel.Country;
                                user.Address = editProfileViewModel.Address;
                                user.UserId = use.Id;
                                users_İnformation.Users = new Users();
                                _usersInformationService.Insert(user);
                                return RedirectToAction("Profile", "Profile");
                            }
                        }
                    }
                }
            }

            return View();
        }
    }
}
