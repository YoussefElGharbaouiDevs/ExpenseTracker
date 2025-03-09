using ExpenseTracker.infrastructure.Common;

namespace ExpenseTracker.infrastructure;

public class AttachmentType : BaseEntity
{
    public string Name { get; set; }
    
    public double MaxFileSize { get; set; }
}