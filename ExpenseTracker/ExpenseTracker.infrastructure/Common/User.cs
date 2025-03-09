using Microsoft.AspNetCore.Identity;

namespace ExpenseTracker.infrastructure.Common;

public class UserEntity : IdentityUser
{
    public string? PreferredCurrency { get; set; }
}