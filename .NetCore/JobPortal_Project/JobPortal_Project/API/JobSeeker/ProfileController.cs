using AutoMapper;
using Domain.Enums;
using Domain.Models;
using Domain.Service.Job;
using Domain.Service.Job.Interfaces;
using Domain.Service.JobSeeker;
using Domain.Service.Login;
using Domain.Service.Login.Interfaces;
using Domain.Service.Profile;
using Domain.Service.Profile.DTOs;
using Domain.Service.Profile.Intefaces;
using Domain.Service.SignUp.Interfaces;
using JobPortal_Project.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Runtime.InteropServices;

namespace JobPortal_Project.API.JobSeeker
{

    [ApiController]

    [Route("API/JobSeeker/Profile")]
    [Authorize(Roles = "JOB_SEEKER")]
    public class ProfileController : BaseApiController<ProfileController>
    {
        private readonly IProfileservice profileservice;
        private readonly IMapper mapper;
        public ProfileController(IProfileservice _profileService, IMapper _mapper)
        {
            profileservice = _profileService;
            mapper = _mapper;
        }


        [HttpPut]
        [Route("job-seeker/Add-Profile-Details")]
        public async Task<IActionResult> UpdateProfile([FromBody] ProfileDto profileRequest)
        {
            if (profileRequest == null)
                return BadRequest("Profile data is required.");
            var AddProfile = mapper.Map<JobSeekerProfile>(profileRequest);
            var isSuccess = await profileservice.UpdateProfileAsync(AddProfile);
            if (isSuccess)
                return Ok("Profile Added successfully");

            return BadRequest("Failed to Add Profile");

        }

        [AllowAnonymous]
        [HttpGet]
        [Route("job-seeker/Profile/{jobSeekerId}/Get-Profile")]
        public async Task<IActionResult> ViewProfile(Guid jobSeekerId)
        {
            ProfileDto getProfile = await profileservice.ViewProfileDetailsAsync(jobSeekerId);
            if (getProfile == null)
                return NotFound();

            return Ok(getProfile);
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("job-seeker/Profile/{jobSeekerProfileId}/Upload-Resume")]
        public async Task<IActionResult> UploadResume([FromForm] ResumeUploadDto dto)
        {
            var isExistProfile = await profileservice.VerifyProfileIdAsync(dto.JobSeekerProfileId);
            if (!isExistProfile)
                return NotFound("Profile not found.");

            if (dto.ResumeFile == null || dto.ResumeFile.Length == 0)
                return BadRequest("No file uploaded.");

            // Convert file to byte[] for DB storage
            using var memoryStream = new MemoryStream();
            var resumeid = profileservice.LoadResume(memoryStream, dto.Title, dto.JobSeekerProfileId);

            return Ok(new { message = "Resume uploaded successfully", resumeid });
        }

        [AllowAnonymous]
        [HttpPut]
        [Route("job-seeker/Profile/{jobSeekerProfileId}/Update-Resume")]
        public async Task<IActionResult> UpdateResume([FromForm] ResumeUploadDto dto)
        {
            var isExistProfile = await profileservice.VerifyProfileIdAsync(dto.JobSeekerProfileId);
            if (!isExistProfile)
                return NotFound("Profile not found.");
            if (dto.ResumeFile == null || dto.ResumeFile.Length == 0)
                return BadRequest("No file uploaded.");

            // Convert file to byte[] for DB storage
            using var memoryStream = new MemoryStream();
            var resumeid = profileservice.UpdateResume(memoryStream, dto.Title, dto.JobSeekerProfileId);

            return Ok(new { message = "Resume updated successfully", resumeid });
        }


        //Uploading image
        [AllowAnonymous]
        [HttpPost]
        [Route("job-seeker/Profile/{jobSeekerProfileId}/Upload-ImageJobSeeker")]
        public async Task<IActionResult> UploadSeekerImage([FromForm] JobSeekerImageUploadDto imageDto)
        {
            var isExistProfile = await profileservice.VerifyProfileIdAsync(imageDto.JobSeekerProfileId);
            if (!isExistProfile)
                return NotFound("Profilenot found");

            if (imageDto.File == null || imageDto.File.Length == 0)
                return BadRequest("No file uploaded");

            using var memoryStream = new MemoryStream();
            var imageSeekerID = profileservice.LoadImage(memoryStream, imageDto.FileName, imageDto.ContentType, imageDto.JobSeekerProfileId);
            return Ok(new { message = "Image uploaded successfully", imageSeekerID });
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("job-seeker/Profile/{jobSeekerProfileId}/Add-WorkExperience")]
        public async Task<IActionResult> AddWorkExperience(Guid jobSeekerProfileId, [FromBody] WorkExperienceDto dataRequest)
        {
            var isExist = profileservice.VerifyProfileIdAsync(jobSeekerProfileId);
            if (isExist == null)
                return BadRequest("Profile ID mismatch.");
            var isSuccess = profileservice.insertWorkExperience(jobSeekerProfileId, dataRequest);
            if (isSuccess != null)
                return Ok("WorkExperience Added Succssfully");

            return BadRequest("Not success");
        }

        //JobSeekerProfileSkill Add
        [AllowAnonymous]
        [HttpPost("{jobSeekerId}/skills")]
        public async Task<IActionResult> AddSkills(Guid jobSeekerProfileId, [FromBody] List<Guid> skillId)
        {
            await profileservice.AddSkillsToJobSeekerAsync(jobSeekerProfileId, skillId);
            return Ok("Skills added successfully");
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("job-seeker/Profile/{jobSeekerProfileId}/Add-Qualification")]
        public async Task<IActionResult> AddQualifications(Guid jobSeekerProfileId, [FromBody] List<Guid> qualifIDs)
        {
            await profileservice.AddQualificatnToJobSeekerAsync(jobSeekerProfileId, qualifIDs);
            return Ok("Qualifications added successfully");
        }

    }

}


