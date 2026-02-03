using AutoMapper;
using Domain.Models;
using Domain.Service.Job;
using Domain.Service.Job.DTOs;
using Domain.Service.Job.Interfaces;
using JobPortal_Project.Controllers;
using Microsoft.AspNetCore.Mvc;


namespace JobPortal_Project.API.JobSeeker
{
    [ApiController]
    [Route("API/JobSeeker/Job")]
    public class JobController : BaseApiController<JobController>
    {
        private readonly IJobService jobservice;
        private readonly IMapper mapper;

        public JobController(IJobService _jobService, IMapper _mapper)
        {
            jobservice = _jobService;
            mapper = _mapper;
        }
        //List all Jobs
        [HttpGet("{jobSeekerId}/Get-Jobs")]
        public async Task<IActionResult> GetAllJobs(Guid jobSeekerId)
        {
            var seekerExists = await jobservice.VerifyJobSeekerId(jobSeekerId);
            if (seekerExists == false)
                return NotFound("Profile not found.");

            var jobs = await jobservice.GetAllJobsList();
            if (jobs == null)
                return NotFound("No jobs found.");

            return Ok(jobs);
        }

        //Apply for job
        [HttpPost("/ApplyforJob")]
        //("-  POST /API/JobSeeker/Job/{jobSeekerId}/Apply/{jobPostId}\r\n- \r\n")
        public async Task<IActionResult> ApplyForJob([FromBody] JobApplicationDto dtoData)
        {
            var validateData = await jobservice.insertIntoJobApplication(dtoData.JobPostId, dtoData.ProfileId);
            if (validateData) return Ok("Applied for this Job successfully. ");
            return BadRequest("Not applied");
        }

        //Search job by companyID
        [HttpGet("/Search/JobByCompanyId/{companyID}")]
        public async Task<IActionResult> SearchJobbycompanyID(Guid companyID)
        {
            var searchJob = await jobservice.searchJobbyCompanyId(companyID);
            if (searchJob != null) return Ok(searchJob);
            return BadRequest("Job is not found");
        }
        //SearchJob by LocationId
        [HttpGet("/Search/JobByLocationId/{locationID}")]
        public async Task<IActionResult> SearchJobbyLocationID(Guid locationID)
        {
            var searchJob = await jobservice.searchJobbyLocationId(locationID);
            if (searchJob != null) return Ok(searchJob);
            return BadRequest("Job is not found");
        }

        //Save job
        [HttpPost("/SaveJob/{JobPostId}")]
        public async Task<IActionResult> SaveJob(Guid JobPostId, Guid seekerprofileID)
        {
            var saveJob = await jobservice.saveJobforLater(JobPostId, seekerprofileID);
            if (saveJob) return Ok("Job successfully saved");
            return BadRequest("Job not found or JobSeekerProfileID is not valid");
        }

        //Delete SavedJob
        [HttpDelete("/DeleteSavedJob/{jobPostId}")] // Match the variable name below
        public async Task<IActionResult> DeleteSavedJob([FromRoute] Guid jobPostId)
        {
            bool issuccess = await jobservice.deleteJobforLater(jobPostId);
            if (issuccess) return Ok("Successfully deleted");
            return BadRequest("Not deleted");
        }

        
    }


}

