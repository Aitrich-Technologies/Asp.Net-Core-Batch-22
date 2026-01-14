using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Service.Login.Interfaces
{
    public interface ILoginRequestRepository
    {
        AuthUser GetUserByEmail(string email);
        AuthUser GetUserByEmailpassword(string email, string password);
    }
}
