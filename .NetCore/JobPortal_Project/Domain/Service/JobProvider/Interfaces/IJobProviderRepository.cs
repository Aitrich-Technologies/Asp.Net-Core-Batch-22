using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Service.JobProvider.Interfaces
{
    public interface IJobProviderRepository
    {
        Guid AddSignupRequest(SignUpRequest signUpRequest);
        Task<SignUpRequest> GetSignupRequestByIdAsync(Guid jobProviderSignupRequestId);
        void UpdateSignupRequest(SignUpRequest signUpRequest);
    }
}
