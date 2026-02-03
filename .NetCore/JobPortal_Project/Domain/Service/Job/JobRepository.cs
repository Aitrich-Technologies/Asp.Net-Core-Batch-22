using AutoMapper;
using Domain.Models;
using Domain.Service.Job.DTOs;
using Domain.Service.Job.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Domain.Service.Job
{
    public class JobRepository : IJobRepository
    {
        private readonly DbHireMeNowWebApiContext _context;
        private readonly IMapper _mapper;

        public JobRepository(DbHireMeNowWebApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> VerifyJobSeekerId(Guid seekerId)
        {
            var isExists = await _context.JobSeekerProfiles.AnyAsync(p => p.JobSeekerId == seekerId);

            if (isExists != null)
                return true;
            return false;
        }
        //Get all jobs
        public async Task<List<JobPostDto>> GetAllJobsListAsync()
        {
            var jobs = await _context.JobPosts.ToListAsync();
            var allJobs = _mapper.Map<List<JobPostDto>>(jobs);
            return allJobs;
        }

        //verify seeker
        public async Task<bool> VerifyJobSeekerProfileID(Guid JobseekerProfileID)
        {
            var isValid = await _context.JobSeekerProfiles.FindAsync(JobseekerProfileID);
            if (isValid != null) return true;
            return false;
        }
        public async Task<bool> insertIntoJobApplication(Guid jobPostId, Guid ProfileId)
        {
            var applyJob = await _context.JobPosts.FindAsync(jobPostId);
            var jobSeeker = await _context.JobSeekerProfiles.FindAsync(ProfileId);
            var existingApplication = await _context.JobApplications.FirstOrDefaultAsync(a => a.JobSeekerProfileId == ProfileId && a.JobPostId == jobPostId);

            if (applyJob == null && jobSeeker == null && existingApplication != null)
                return false;


            // Create new JobApplication
            var application = new JobApplication
            {
                JobSeekerProfileId = ProfileId,
                JobPostId = jobPostId,
                JobTitle = applyJob.JobTitle,
                JobSummary = applyJob.JobSummary,
                LocationId = applyJob.LocationId,
                CompanyId = applyJob.CompanyId,
                AppliedDate = DateTime.UtcNow

            };

            // Save to DB
            _context.JobApplications.Add(application);
            await _context.SaveChangesAsync();

            return true;
        }
        public async Task<List<JobSearchDto>> searchJobbyCompanyId(Guid companyID)
        {
            var job = await _context.JobPosts.Where(j => j.CompanyId == companyID).ToListAsync();
            var jobgot = _mapper.Map<List<JobSearchDto>>(job);
            return jobgot;

        }

        public async Task<List<JobSearchDto>> searchJobbyLocationIDAsync(Guid locationID)
        {
            var job = await _context.JobPosts.Where(j => j.LocationId == locationID).ToListAsync();
            var jobgot = _mapper.Map<List<JobSearchDto>>(job);
            return jobgot;
        }

        public async Task<bool> saveJobforLaterAsync(Guid jobPostId, Guid seekerprofileID)
        {
            var seeker = await VerifyJobSeekerId(seekerprofileID);
            var job = await _context.JobPosts.FindAsync(jobPostId);
            if (job == null && seeker == false) return false;
            var jobSave = new JobSaved()
            {
                Id = Guid.NewGuid(),
                JobPostId = jobPostId,
                JobSeekerProfileId = seekerprofileID,
            };
             _context.JobSaved.Add(jobSave);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> deleteJobforLater(Guid jobPostId)
        {
            // Look for the record where the JobPostId column matches
            var job = await _context.JobSaved.FirstOrDefaultAsync(x => x.JobPostId == jobPostId);

            if (job != null)
            {
                _context.JobSaved.Remove(job);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }
        

    }
}


