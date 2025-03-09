using System.ComponentModel.DataAnnotations;
using ExpenseTracker.infrastructure.Common;

namespace ExpenseTracker.infrastructure;

public class ExpenseEntity : BaseEntity
{
    [Required]
    public decimal Amount { get; set; }
    
    [Required]
    public DateOnly Date { get; set; }
    
    public string Description { get; set; }
    
    [Required]
    public int CategoryId { get; set; } 
    
    public bool IsRecurring { get; set; }
    
    public int? RecurrenceFrequencyId { get; set; }
    
    [Required]
    public string UserId { get; set; }
    
    public string Currency { get; set; } = "MAD";
    
    public virtual required CategoryEntity CategoryEntity { get; set; }
    
    public virtual required UserEntity User { get; set; }
    
    public virtual RecurrenceFrequency? RecurrenceFrequency { get; set; }
    
    public virtual ICollection<AttachmentEntity> Attachments { get; set; } = new List<AttachmentEntity>();
}