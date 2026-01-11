
using Domain.Models;
using Domain.Service.Authuser.Interfaces;
using Microsoft.AspNetCore.Http;

namespace Domain.Service.Authuser
{
	public class AuthUserService:IAuthUserService
	{
		private readonly IHttpContextAccessor _httpContextAccessor;
		private readonly IAuthUserRepository _userRepository;

		public AuthUserService(IHttpContextAccessor httpContextAccessor,IAuthUserRepository userRepository)
		{
			_httpContextAccessor = httpContextAccessor;
			_userRepository = userRepository;
		}

        

        
    }
}
