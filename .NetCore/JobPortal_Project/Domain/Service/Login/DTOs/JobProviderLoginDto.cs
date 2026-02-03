using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Service.Login.DTOs
{
    public class JobProviderLoginDto
    {
        //public Guid Id { get; set; }
        //public string? UserName { get; set; }
        //public string FirstName { get; set; } = null!;
        //public string? LastName { get; set; }
        //public string Phone { get; set; } = null!;
        //public Role Role { get; set; }
        public string Email { get; set; } = null!;
        public string? Token { get; set; }
    }
}
