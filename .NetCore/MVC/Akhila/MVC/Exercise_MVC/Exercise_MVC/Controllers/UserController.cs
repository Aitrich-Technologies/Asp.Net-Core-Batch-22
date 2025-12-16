using Exercise_MVC.AppServices;
using Exercise_MVC.Dto;
using Exercise_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercise_MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationServices services;
        public UserController(ApplicationServices _services)
        {
            services = _services;
        }
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Registration(User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            bool isRegistered = await services.registerUser(user);

            if (isRegistered)
            {
                return RedirectToAction(nameof(Login));
            }

            ModelState.AddModelError("", "Registration failed. Please try again.");
            return View(user);

        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Login_Dto userlogin)
        {

            bool status = await services.VerifyUser(userlogin);
            if (status)
            {
                HttpContext.Session.SetString("UserEmail", userlogin.Email);
                User userid = await services.GetUserID(userlogin);
               
                return RedirectToAction("Index", "Job");
                //return RedirectToAction("Profile", "User");


            }



            return View();
        }
        //[HttpGet]
        //public async Task<IActionResult> Profile()
        //{
        //    string mail = HttpContext.Session.GetString("UserEmail");
        //    User updateuser = await services.UpdateUser(mail);
        //    return View(updateuser);

        //}
        //[HttpPost]
        //public async Task Profile(User user)
        //{
        //    await services.UpdateDetails(user);

        //}
        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            string mail = HttpContext.Session.GetString("UserEmail");
            User updateuser=await services.UpdateUser(mail);
            return View(updateuser);
        }
        [HttpPost]
        public async Task<IActionResult> Profile(User user)
        {
            await services.UpdateDetails(user);
            return RedirectToAction("Index", "Job");
        }

    }
}
