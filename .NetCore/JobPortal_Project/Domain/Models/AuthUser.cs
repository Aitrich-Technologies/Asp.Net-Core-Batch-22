using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class AuthUser:SystemUser
{
    public Guid Id { get; set; }

    public Guid SystemUserId { get; set; }

    public string Password { get; set; } = null!;
    public string? ConnectionId { get; set; }
    public bool? OnlineStatus { get; set; } = false;

    public virtual SystemUser IdNavigation { get; set; } = null!;

    public virtual SystemUser SystemUser { get; set; } = null!;
}
