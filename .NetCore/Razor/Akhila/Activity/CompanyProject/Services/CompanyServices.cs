using CompanyProject.Repository;
using CompanyProject.Model;
using Microsoft.AspNetCore.Mvc;

namespace CompanyProject.Services
{
    public class CompanyServices
    {
        private readonly CompanyRepository _companyRepository;
        public CompanyServices(CompanyRepository companyRepository)
        {
            _companyRepository= companyRepository;
        }
        public async Task AddNewUserAsync( CompanyUser NewUser)
        {
            await _companyRepository.AddNewUserAsync(NewUser);
        }

        public async Task<bool> ValidateUserAsync(string UserName, string Password)
        {
            return await _companyRepository.ValidateUserAsync(UserName, Password);
        }
    }
        
    
}
