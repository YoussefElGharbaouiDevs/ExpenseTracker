namespace ExpenseTracker.api.Dtos.Attachment;

public class AttachmentRequest
{
    public IFormFile File { get; set; }
    
    public string Name { get; set; }
    
    public string OriginalName { get; set; }
    
    public string Path { get; set; }
    
    public double FileSize { get; set; }
    public int ExpenseId { get; set; }
    
    public int AttachmentTypeId { get; set; }
}