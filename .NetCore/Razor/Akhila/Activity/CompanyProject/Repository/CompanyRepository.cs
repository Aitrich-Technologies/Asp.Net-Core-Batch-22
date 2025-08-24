using AutoMapper;
using CompanyProject.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CompanyProject.Repository
{
    public class CompanyRepository
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _contextAccessor;
        public CompanyRepository(ApplicationDBContext dbContext, IMapper mapper,IHttpContextAccessor httpcontextAccessor)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _contextAccessor = httpcontextAccessor;
        }
        public async Task AddNewUserAsync(CompanyUser NewUser)
        {
            _dbContext.companyUsers.Add(NewUser);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> ValidateUserAsync(string UserName, string Password)
        {
            //string Username = _contextAccessor.HttpContext.Session.GetString(UserName);
            //string password = _contextAccessor.HttpContext.Session.GetString(Password);
            var user = _dbContext.companyUsers.SingleOrDefault(u => u.name == UserName && u.password==Password);
            if (user == null)
            {
                return false;
            }
            return true;
        }
               
    }
}
