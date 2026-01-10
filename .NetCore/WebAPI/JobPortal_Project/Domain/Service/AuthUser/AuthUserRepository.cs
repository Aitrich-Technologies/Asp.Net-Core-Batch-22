using AutoMapper;
using Domain.Models;
using Domain.Service.Authuser.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Domain.Service.Authuser
{
    public class AuthUserRepository: IAuthUserRepository
    {
        protected readonly DbHireMeNowWebApiContext _context;
        IMapper mapper;
        private readonly IConfiguration _configuration;
        public AuthUserRepository(DbHireMeNowWebApiContext dbContext,IMapper _mapper, IConfiguration configuration)
        {
            _context = dbContext;
            mapper = _mapper;
            _configuration = configuration;
        }

        public Task<AuthUser> AddAuthUser(AuthUser authUser)
        {
            throw new NotImplementedException();
        }

        public Task<AuthUser> AddAuthUserJP(AuthUser authUser)
        {
            throw new NotImplementedException();
        }

        public string? CreateToken(AuthUser user)
        {
            throw new NotImplementedException();
        }

        public CompanyUser GetUser(Guid userid)
        {
            throw new NotImplementedException();
        }

        public Task AddUserConnectionIdAsync(string email, string ConnectionId)
        {
            throw new NotImplementedException();
        }

        public AuthUser GetUserByConnectionId(string connectionId)
        {
            throw new NotImplementedException();
        }

        public Task<AuthUser> GetAuthUserByUserEmail(string user)
        {
            throw new NotImplementedException();
        }

        public void DisconnectUserByConnectionId(string connectionId)
        {
            throw new NotImplementedException();
        }

        public Task<AuthUser> GetAuthUserByUserId(Guid value)
        {
            throw new NotImplementedException();
        }
    }
}
