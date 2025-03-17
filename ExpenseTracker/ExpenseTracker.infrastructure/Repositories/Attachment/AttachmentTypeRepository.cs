using ExpenseTracker.infrastructure.Models;

namespace ExpenseTracker.infrastructure.Repositories.Attachment;

public class AttachmentTypeRepository(ExpenseTrackerDbContext context) : GenericRepository<AttachmentTypeEntity>(context), IAttachmentTypeRepository
{
    
}