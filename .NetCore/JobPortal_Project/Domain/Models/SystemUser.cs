using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class SystemUser
{
    public Guid Id { get; set; }= Guid.NewGuid();

    public string? UserName { get; set; }

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public Enums.Role Role { get; set; }
    public virtual JobSeeker? JobSeeker { get; set; }


}
