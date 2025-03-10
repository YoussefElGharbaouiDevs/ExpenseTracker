using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.infrastructure.Models.Common;

public class CurrencyEntity : BaseEntity
{
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    
    [Required]
    [StringLength(3)]
    public string Abbreviation { get; set; }
    
    [Required]
    public string Description { get; set; }
}