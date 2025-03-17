using System.Collections;
using ExpenseTracker.api.Dtos.Attachment;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.api.Services.Attachment;

public interface IAttachmentService
{
    Task<IEnumerable<AttachmentResponse>> GetAllAsync();
    Task<ActionResult<AttachmentResponse>> GetAsync(int id);
    Task AddAsync(AttachmentRequest entityDto);
    Task UpdateAsync(AttachmentRequest entityDto);
    Task DeleteAsync(AttachmentRequest entityDto);
}