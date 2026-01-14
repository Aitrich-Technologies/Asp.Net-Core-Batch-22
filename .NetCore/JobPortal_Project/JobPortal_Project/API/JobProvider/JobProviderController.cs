using AutoMapper;
using Domain.Service.JobProvider.Interfaces;
using Domain.Service.SignUp.DTOs;
using JobPortal_Project.API.JobProvider.RequestObjects;
using JobPortal_Project.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobPortal_Project.API.JobProvider
{
    //[Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "JOB_PROVIDER")]
    public class JobProviderController : BaseApiController<JobProviderController>
    {
        private readonly IJobProviderService _jobProviderService;
        private readonly IMapper mapper;
        public JobProviderController(IJobProviderService jobProviderService, IMapper mapper)
        {
            _jobProviderService = jobProviderService;
            this.mapper = mapper;
        }

        [HttpPost]
        [Route("Job-Provider/Signup")]
        [AllowAnonymous]
        public async Task<IActionResult> createJobProviderSignupRequest(JobProviderSignupRequest data)
        {
            var jobprovidersignuprequestdto=mapper.Map<JobProviderSignupRequestDto>(data);
            _jobProviderService.CreateSignupRequest(jobprovidersignuprequestdto);
            return Ok(data);
        }
        [HttpGet]
        [Route("job-provider/signup/{signupRequestId}/verify-email")]
        [AllowAnonymous]
        public async Task<ActionResult> VerifyJobProviderEmail(Guid signupRequestId)
        {
            var isVerified=await _jobProviderService.VerifyEmailAsync(signupRequestId);
            if(isVerified)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpPost]
        [Route("job-provider/signup/{jobProviderSignupRequestId}/set-password")]
        [AllowAnonymous]
        public async Task<ActionResult> createJobProviderSignupRequest(Guid jobProviderSignupRequestId, [FromBody] string password)
        {
            await _jobProviderService.CreateJobProvider(jobProviderSignupRequestId, password);
            return Ok("Password set successfully");
        }


    }
}
