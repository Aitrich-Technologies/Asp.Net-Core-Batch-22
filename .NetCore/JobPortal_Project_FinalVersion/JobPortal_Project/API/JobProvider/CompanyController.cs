using AutoMapper;
using Domain.Service.JobProvider.Interfaces;
using JobPortal_Project.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JobPortal_Project.API.JobProvider.RequestObjects;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.JobProvider.DTOs;
using Domain.Service.JobProvider;
using Domain.Models;
using Domain.Helpers;

namespace JobPortal_Project.API.JobProvider
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "JOB_PROVIDER")]
    public class CompanyController : BaseApiController<CompanyController>
    {
        private readonly ICompanyService companyService;
        private readonly IAuthUserService authUserService;
        private readonly IMapper mapper;
        public CompanyController(ICompanyService companyService, IAuthUserService authUserService, IMapper mapper)
        {
            this.companyService = companyService;
            this.authUserService = authUserService;
            this.mapper = mapper;
        }
        [HttpPost]
        [Route("job-provider/{jobproviderId}/Registercompany")]
        public async Task<ActionResult> AddCompany(AddCompanyRequest data)
        {
            var userid = authUserService.GetUserId();
            var companyregistrationdto = mapper.Map<CompanyRegistrationDto>(data);
            var company = await companyService.AddCompany(companyregistrationdto, new Guid(userid));
            return Ok(company);



        }
        [AllowAnonymous]
        [HttpGet]
        [Route("job-provider/company/{companyId}/FetchCompanyDetails")]
        public async Task<ActionResult> getCompany(Guid companyId)
        {
            var company=await companyService.GetCompany(companyId);
            if(company == null)
            {
                return BadRequest("Company Details not found");
            }

            return Ok(company);
        }
        [AllowAnonymous]
        [HttpPut]
        [Route("job-provider/company/{companyId}/UpdateCompany")]
        public async Task<ActionResult> UpdateCompany(Guid companyId, CompanyupdateRequest company)
        {
            if (companyId == null)
            {
                return BadRequest("Id is Required");
            }
            if(companyId==company.Id)
            {
                var companyupdatedto=mapper.Map<CompanyUpdateDtos>(company);
                var  updatedcompany= await companyService.UpdateAsync(companyupdatedto);
                if(updatedcompany==null)
                {
                    return NotFound("Company Not Found");
                }
                return Ok(updatedcompany);
            }
            return BadRequest("Company Id Mismatch");
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("job-provider/company/{companyId}/Addcompanymember")]
        public async Task<ActionResult> AddCompanyMember(CompanyUserRequest request, Guid companyId)
        {
            try
            {
                var companymemberdtos = mapper.Map<CompanyMemberDtos>(request);
                var newmember = await companyService.addMember(companymemberdtos, companyId);
                return Ok(companyId);

            }
            catch (Exception ex) 
            {
                    return BadRequest(ex.Message);

            }

        }
        [AllowAnonymous]
        [HttpGet]
        [Route("job-provider/company/{companyId}/listcompanymember")]
        public async Task<ActionResult> ListCompanyMember(Guid companyId, [FromQuery] CompanyMemberListParam param)
        {

            if (companyId == null)
            {
                return BadRequest("Id is Required");
            }
            var companymembers=await companyService.memberListing(companyId,param);
            PagedList<CompanyMemberListDtos> companyMemberDtos=mapper.Map<PagedList<CompanyMemberListDtos>>(companymembers);
            if (companymembers == null)
            {
                return BadRequest("No Company Members");

            }
            else
            {
                return Ok(companymembers);
            }
        }
        [AllowAnonymous]
        [HttpDelete]
        [Route("job-provider/company/{companyMemberId}/RemoveCompanyMember")]
        public IActionResult memberDelete(Guid companyMemberId)
        {
            var result=companyService.memberDeleteById(companyMemberId);
            if(result==true)
            {
                return Ok("Member deleted successfully");
            }
            else
            {
                return NotFound("Member not found");
            }
        }




    }
}
