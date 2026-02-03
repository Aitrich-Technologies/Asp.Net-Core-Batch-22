using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public partial class JobSeeker
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string? UserName { get; set; }
    public string FirstName { get; set; } = null!;
    public string? LastName { get; set; }
    public string Phone { get; set; } = null!;
    public string? Email { get; set; } = null!;
    public Domain.Enums.Role Role { get; set; }

    public Guid SystemUserId { get; set; }
    // This tells EF: "Use the property above"
    [ForeignKey("SystemUserId")]
    public virtual SystemUser SystemUser { get; set; } = null!;
}




