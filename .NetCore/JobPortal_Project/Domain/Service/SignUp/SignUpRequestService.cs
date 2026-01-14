using AutoMapper;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.SignUp.DTOs;
using Domain.Service.SignUp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;
using Domain.Helpers;

namespace Domain.Service.SignUp
{
    public class SignUpRequestService : ISignUpRequestService
    {

        ISignUpRequestRepository jobSeekerRepository;
        IAuthUserRepository authUserRepository;
        IMapper mapper;
        IEMailService emailService;

        public SignUpRequestService(ISignUpRequestRepository jobSeekerRepository, IAuthUserRepository authUserRepository, IMapper mapper, IEMailService emailService)
        {
            this.jobSeekerRepository = jobSeekerRepository;
            this.authUserRepository = authUserRepository;
            this.mapper = mapper;
            this.emailService = emailService;
        }
        public async void CreateSignupRequest(JobSeekerSignupRequestDto data)
        {
            var signUpRequest = mapper.Map<SignUpRequest>(data);
            var signUpId = jobSeekerRepository.AddSignupRequest(signUpRequest);
            MailRequest mailRequest = new MailRequest();
            mailRequest.Subject = "HireMeNow SignUp Verification";
            mailRequest.Body = "http://localhost:4200/set-password?signupid=" + signUpId.ToString();
            mailRequest.ToEmail = signUpRequest.Email;
            await emailService.SendEmailAsync(mailRequest);

        }
        
    }
}
