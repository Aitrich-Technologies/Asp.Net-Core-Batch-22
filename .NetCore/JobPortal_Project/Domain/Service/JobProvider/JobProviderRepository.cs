using Domain.Models;
using Domain.Service.JobProvider.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;

namespace Domain.Service.JobProvider
{
    public class JobProviderRepository : IJobProviderRepository
    {
        DbHireMeNowWebApiContext context;
        public JobProviderRepository(DbHireMeNowWebApiContext context)
        {
            this.context = context;
        }
        public async Task<SignUpRequest> GetSignupRequestByIdAsync(Guid jobProviderSignupRequestId)
        {
            return await context.SignUpRequests.FindAsync(jobProviderSignupRequestId);
        }
        public async void UpdateSignupRequest(SignUpRequest signUpRequest)
        {
            context.SignUpRequests.Update(signUpRequest);
            await context.SaveChangesAsync();

        }
        public Guid AddSignupRequest(SignUpRequest signUpRequest)
        {
            signUpRequest.Status = Status.PENDING;
            context.SignUpRequests.AddAsync(signUpRequest);
            context.SaveChanges();
            return signUpRequest.Id;
        }
    }
}
