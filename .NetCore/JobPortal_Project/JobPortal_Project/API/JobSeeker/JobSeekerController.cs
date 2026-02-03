using AutoMapper;
using Domain.Service.Login.Interfaces;
using Domain.Service.Profile.DTOs;
using Domain.Service.SignUp.DTOs;
using Domain.Service.SignUp.Interfaces;
using JobPortal_Project.API.JobSeeker.RequestObjects;
using JobPortal_Project.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace JobPortal_Project.API.JobSeeker
{
    [ApiController]

    [Route("API/JobSeeker")]
    public class JobSeekerController : BaseApiController<JobSeekerController>
    {
        public ISignUpRequestService jobSeekerService { get; set; }
        public ILoginRequestService loginRequestService { get; set; }
        public IMapper mapper { get; set; }
        public JobSeekerController(ISignUpRequestService _jobSeekerService, ILoginRequestService _loginRequestService, IMapper _mapper)
        {
            jobSeekerService = _jobSeekerService;
            loginRequestService = _loginRequestService;
            mapper = _mapper;
        }
        [HttpPost]

        public async Task<ActionResult> createJobSeekerSignupRequest(JobSeekerSignupRequest data)
        {
            var JobSeekerSignupRequestDto = mapper.Map<JobSeekerSignupRequestDto>(data);
            await jobSeekerService.CreateSignupRequest(JobSeekerSignupRequestDto);
            return Ok(data);
        }

        [HttpGet]
        [Route("job-seeker/signup/{jobSeekerSignupRequestId}/verify-email")]

        public async Task<ActionResult> VerifyJobSeekerEmail(Guid jobSeekerSignupRequestId)
        {
            var isverified = await jobSeekerService.VerifyEmailAsync(jobSeekerSignupRequestId);
            if (isverified)
            {
                return Ok();
            }
            return BadRequest();
        }


        [HttpPost]
        [Route("job-seeker/signup/{jobSeekerSignupRequestId}/set-password")]
        public async Task<IActionResult> createJobSeekerSignupRequest(Guid jobSeekerSignupRequestId, [FromBody] string password)
        {
            await jobSeekerService.CreateJobseeker(jobSeekerSignupRequestId, password);
            return Ok("Password set successfully");
        }


        [HttpPost]
        [Route("job-seeker/login")]
        public async Task<IActionResult> Login(JobSeekerLoginRequest logdata)
        {
            var user = loginRequestService.login(logdata.Email, logdata.Password);
            if (user == null)
                return BadRequest("Login Failed");
            else
                return Ok(user);
        }


    }
}
