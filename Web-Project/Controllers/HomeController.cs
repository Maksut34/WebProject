<<<<<<< HEAD
﻿
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using Web_BLL.Abstract;
using Web_DTO.DTO.UsersLoginDTO;
using Web_Entity.Models;
=======
﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
using Web_Project.Models;

namespace Web_Project.Controllers
{
    public class HomeController : Controller
    {
<<<<<<< HEAD

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
=======
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
        public IActionResult Keşfet()
        {
            return View();
        }
        [Authorize]
<<<<<<< HEAD
        [HttpGet]
        public IActionResult AnaSayfa()
        {

            var stor = _addStoryService.getAll().ToList();



            return View(new UsersLoginDTO
            {
                addStories = stor.Take(10).ToList()
            });
            
=======
        public IActionResult AnaSayfa()
        {
            return View();
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
        }
        [Authorize]
        public IActionResult About()
        {
            return View();
        }
        [Authorize]
<<<<<<< HEAD
        [HttpGet]
=======
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
        public IActionResult Contact()
        {
            return View();
        }
        
<<<<<<< HEAD
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

=======
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
>>>>>>> 1058286ea13219f1c102be35469122af732c2ddb
    }
}