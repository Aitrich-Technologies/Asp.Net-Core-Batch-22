using Domain.Enums;
using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class SignUpRequest
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string? UserName { get; set; }

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public Status Status { get; set; }
}
