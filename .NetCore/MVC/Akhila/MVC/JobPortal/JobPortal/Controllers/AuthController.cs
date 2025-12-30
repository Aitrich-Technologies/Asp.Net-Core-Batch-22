using JobPortal.Dto;
using JobPortal.Models;
using JobPortal.Service;
using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Controllers
{
    public class AuthController : Controller
    {
        private readonly JobPortalService _jobService;

        public AuthController(JobPortalService jobService)
        {
            _jobService = jobService;
        }
        public IActionResult Registration_Jobprovider()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Registration_Jobprovider(User user)
        {

            if (!ModelState.IsValid)
            {
                return View(user);
            }

            bool isRegistered = await _jobService.registerUser(user);

            if (isRegistered)
            {
                return RedirectToAction(nameof(PublicLogin));
            }

            ModelState.AddModelError("", "Registration failed. Please try again.");
            return View(user);

            //bool login=await _jobService.registerUser(user);
            //if(login) return RedirectToAction(nameof(PublicLogin));
            //else return View();
        }

        public IActionResult PublicLogin()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> PublicLogin(UserLoginDto userLogin)
        {
            
            bool status = await _jobService.VerifyUser(userLogin);
            if (status)
            {
                HttpContext.Session.SetString("UserEmail", userLogin.Email);
                return RedirectToAction("Index","Job");
            }
            else
            {
                return View();
            }
        }
    }
}

