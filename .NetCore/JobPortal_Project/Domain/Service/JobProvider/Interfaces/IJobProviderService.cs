using Domain.Service.SignUp.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Service.JobProvider.Interfaces
{
    public interface IJobProviderService
    {
        void CreateSignupRequest(JobProviderSignupRequestDto data);
        Task<bool> VerifyEmailAsync(Guid jobProviderSignupRequestId);
        Task CreateJobProvider(Guid jobProviderSignupRequestId, string password);
    }
}
