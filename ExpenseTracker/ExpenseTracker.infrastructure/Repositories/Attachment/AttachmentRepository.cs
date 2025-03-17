using ExpenseTracker.infrastructure.Models;

namespace ExpenseTracker.infrastructure.Repositories.Attachment;

public class AttachmentRepository(ExpenseTrackerDbContext context) : GenericRepository<AttachmentEntity>(context), IAttachmentRepository
{
    
}