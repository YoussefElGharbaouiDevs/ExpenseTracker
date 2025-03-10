using Microsoft.AspNetCore.Identity;

namespace ExpenseTracker.infrastructure.Models.Common;

public class UserEntity : IdentityUser
{
    public string? PreferredCurrency { get; set; }
}