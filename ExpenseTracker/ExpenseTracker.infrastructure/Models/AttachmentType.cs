using ExpenseTracker.infrastructure.Models.Common;

namespace ExpenseTracker.infrastructure.Models;

public class AttachmentType : BaseEntity
{
    public string Name { get; set; }
    
    public double MaxFileSize { get; set; }
}