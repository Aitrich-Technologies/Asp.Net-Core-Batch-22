using AutoMapper;
using Domain.Helpers;
using Domain.Models;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.JobProvider.Interfaces;
using Domain.Service.SignUp.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Service.JobProvider
{
    public class JobProviderService:IJobProviderService
    {
        IJobProviderRepository jobProviderRepository;
        IMapper mapper;
        IEMailService emailService;
        IAuthUserRepository authUserRepository;
        public JobProviderService(IJobProviderRepository jobProviderRepository,IMapper mapper,IEMailService eMailService,IAuthUserRepository authUserRepository )
        {
            this.jobProviderRepository = jobProviderRepository;
            this.mapper = mapper;
            emailService= eMailService;
            this.authUserRepository = authUserRepository;
        }
        public async void CreateSignupRequest(JobProviderSignupRequestDto data)
        {
            var signuprequest = mapper.Map<SignUpRequest>(data);
            var signupId = jobProviderRepository.AddSignupRequest(signuprequest);
            MailRequest mailRequest = new MailRequest();
            mailRequest.Subject = "HireMeNow SignUp Verification";
            mailRequest.Body = "http://localhost:56067/set-password?signupid=" + signupId.ToString();
            mailRequest.ToEmail = signuprequest.Email;


        }
        public async Task<bool> VerifyEmailAsync(Guid jobProviderSignupRequestId)
        {
            SignUpRequest signUpRequest = await jobProviderRepository.GetSignupRequestByIdAsync(jobProviderSignupRequestId);
            if (signUpRequest != null)
            {
                signUpRequest.Status = Enums.Status.VERIFIED;
                jobProviderRepository.UpdateSignupRequest(signUpRequest);
                return true;
            }
            return false;
        }
        public async Task CreateJobProvider(Guid jobProviderSignupRequestId, string password)
        {
            try
            {
                SignUpRequest signUpRequest = await jobProviderRepository.GetSignupRequestByIdAsync(jobProviderSignupRequestId);
                AuthUser authUser = new();
                if(signUpRequest.Status== Enums.Status.VERIFIED)
                {
                    authUser.UserName = signUpRequest.UserName;
                    authUser.Role =(int) Enums.Role.JOB_PROVIDER;
                    authUser.FirstName = signUpRequest.FirstName;
                    authUser.LastName = signUpRequest.LastName;
                    authUser.Email = signUpRequest.Email;
                    authUser.Password = password;
                    authUser.Phone = signUpRequest.Phone;
                    authUser = await authUserRepository.AddAuthUserJP(authUser);
                    signUpRequest.Status = Enums.Status.CREATED;
                    jobProviderRepository.UpdateSignupRequest(signUpRequest);





                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
