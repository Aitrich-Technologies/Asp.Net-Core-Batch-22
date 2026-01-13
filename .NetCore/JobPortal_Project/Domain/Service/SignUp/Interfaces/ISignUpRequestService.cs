using Domain.Service.SignUp.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Service.SignUp.Interfaces
{
    public interface ISignUpRequestService
    {
        void CreateSignupRequest(JobSeekerSignupRequestDto data);
    }
}
