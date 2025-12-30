using JobPortal.Models;
using JobPortal.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JobPortal.Controllers
{
    public class JobController : Controller
    {
        private readonly JobPortalService _jobService;

        public JobController(JobPortalService jobService)
        {
            _jobService = jobService;
        }
        public async Task<IActionResult> Index()
        {
            var useremail = HttpContext.Session.GetString("UserEmail");
            List<Job> alljobs = await _jobService.GetAllJobs();
            return View(alljobs);
        }
        
        public IActionResult JobRegistrtion()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> JobRegistrtion(Job job)
        {
            if(!ModelState.IsValid) return View(job);
            await _jobService.AddJob(job);
            return RedirectToAction(nameof(Index));
        }
    }
}
