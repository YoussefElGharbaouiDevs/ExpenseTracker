using ExpenseTracker.infrastructure.Models.Common;

namespace ExpenseTracker.infrastructure.Models;

public class AttachmentEntity : BaseEntity
{
    public string Name { get; set; }
    
    public string OriginalName { get; set; }
    
    public string Path { get; set; }
    
    public double FileSize { get; set; }
    
    public int ExpenseId { get; set; }
    
    public int AttachmentTypeId { get; set; }
    
    public virtual required ExpenseEntity ExpenseEntity { get; set; }
    
    public virtual required AttachmentType AttachmentType { get; set; }
}