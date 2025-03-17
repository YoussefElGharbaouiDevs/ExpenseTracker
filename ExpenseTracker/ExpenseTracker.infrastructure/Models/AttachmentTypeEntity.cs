using ExpenseTracker.infrastructure.Models.Common;

namespace ExpenseTracker.infrastructure.Models;

public class AttachmentTypeEntity : BaseEntity
{
    public string Name { get; set; }
    
    public double MaxFileSize { get; set; }
}