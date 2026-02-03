using AutoMapper;
using Domain.Models;
using Domain.Service.JobSeeker.Interfaces;

namespace Domain.Service.JobSeeker
{

    public class JobSeekerService : IJobSeeekerService
    {
        private readonly JobSeekerRepository _jobRepository;
        private readonly IMapper _mapper;
        public JobSeekerService(JobSeekerRepository jobRepository, DbHireMeNowWebApiContext context, IMapper mapper)
        {
            _jobRepository = jobRepository;
            _mapper = mapper;
        }


    }
}
