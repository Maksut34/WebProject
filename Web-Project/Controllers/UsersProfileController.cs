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
<<<<<<< HEAD
        private readonly IImageService _imageService;

        public UsersProfileController(UserManager<Users> userManager,IUsers_InformationService users_InformationService,IImageService ımageService)
        {
            _usersInformationService = users_InformationService;    
            _userManager = userManager;
            _imageService = ımageService;
=======

        public UsersProfileController(UserManager<Users> userManager,IUsers_InformationService users_InformationService)
        {
            _usersInformationService = users_InformationService;    
            _userManager = userManager;
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
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
<<<<<<< HEAD
            Image ımage = new Image();
            Users_İnformation users_İnformation = new Users_İnformation();


            try
            {
                if (User.Identity.IsAuthenticated)
                {
                    var userId = await _userManager.FindByNameAsync(User.Identity.Name);
                    if (userId != null)
                    {


                        users_İnformation.Address = editProfileViewModel.Address;
                        users_İnformation.City = editProfileViewModel.City;
                        users_İnformation.Country = editProfileViewModel.Country;
                        users_İnformation.UserId = userId.Id;
                        //users_İnformation.Users = new Users();

                        ımage.image = editProfileViewModel.image.FileName;



                        if (ModelState.IsValid)
                        {
                            var informationID = await _usersInformationService.FindAsync(i => i.UserId == users_İnformation.UserId);

                            if (informationID != null && users_İnformation.UserId == userId.Id)
                            {
                                informationID.Address = editProfileViewModel.Address;
                                informationID.City = editProfileViewModel.City;
                                informationID.Country = editProfileViewModel.Country;

                                _usersInformationService.Update(informationID);

                            }
                            else
                            {
                                Users_İnformation _İnformation=new Users_İnformation();
                                _İnformation.City = editProfileViewModel.City;
                                _İnformation.Country = editProfileViewModel.Country;
                                _İnformation.Address = editProfileViewModel.Address;
                                _İnformation.UserId = userId.Id;

                                _usersInformationService.Insert(_İnformation);
                            }

                            if (editProfileViewModel.image != null)
                            {
                                var extension = Path.GetExtension(editProfileViewModel.image.FileName);
                                var newimagename = Guid.NewGuid() + extension;
                                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/lib/img/", newimagename);
                                var stream = new FileStream(location, FileMode.Create);
                                editProfileViewModel.image.CopyTo(stream);
                                ımage.image = newimagename;

                                var img = _imageService.Find(i => i.image == ımage.image);
                                if (img == null)
                                {
                                    ımage.UserId = userId.Id;
                                    ımage.image = newimagename;

                                    _imageService.Insert(ımage);

                                }
                                else
                                {
                                    Image ımage1 = new Image();
                                    ımage1.UserId = userId.Id;
                                    ımage1.image = newimagename;

                                    _imageService.Insert(ımage1);

                                }
                                return RedirectToAction("Profile","Profile");
=======

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
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
                            }
                        }
                    }
                }
            }
<<<<<<< HEAD
            catch (Exception ex)
            {
                string errorMessage = ex.Message;
                ViewBag.e = errorMessage;
            }
=======
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb

            return View();
        }
    }
}
