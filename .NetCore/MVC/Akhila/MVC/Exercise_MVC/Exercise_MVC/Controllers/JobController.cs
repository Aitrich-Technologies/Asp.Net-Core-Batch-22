using Exercise_MVC.AppServices;
using Exercise_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercise_MVC.Controllers
{
    public class JobController : Controller
    {
        private readonly ApplicationServices service;
        public JobController(ApplicationServices _service)
        {

            service = _service;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var useremail = HttpContext.Session.GetString("UserEmail");
            var updateuser = HttpContext.Session.GetInt32("UserID");
            var alljobs = await service.GetAllJobs();
            return View("Index",alljobs);

        }
        //[HttpGet]
        //public IActionResult loadjob(int id)
        //{
        //    var jobdetail = service.GetJobID(id);
        //    return PartialView("_loadjob", jobdetail);
        //}

        public IActionResult JobRegistration()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> JobRegistration(Job job)
        {
            if (!ModelState.IsValid)
            {
                return View(job);
            }
            bool Isregistered= await service.JobVerify(job);
                if(Isregistered)
                {
                    return RedirectToAction("Index");
                }
            
            ModelState.AddModelError("", "Job Registration failed. Please try again.");
            return View(job);
        }


        

    }
}
