using AutoMapper;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.SignUp.DTOs;
using Domain.Service.SignUp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;

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
            var signuprequest = mapper.Map<SignUpRequest>(data);
            //var signUpId=
        }
    }
}
