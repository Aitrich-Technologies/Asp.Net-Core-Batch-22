using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Service.SignUp.Interfaces
{
    public interface ISignUpRequestRepository
    {
        Guid AddSignupRequest(SignUpRequest signUpRequest);
    }
}
