using ExpenseTracker.api.Dtos.Attachment;
using ExpenseTracker.api.Services.Attachment;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AttachmentController(IAttachmentService attachmentService) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AttachmentResponse>>> GetAll()
    {
        var attachments = await attachmentService.GetAllAsync();
        return Ok(attachments);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<AttachmentResponse>> Get(int id)
    {
        var attachment = await attachmentService.GetAsync(id);

        return Ok(attachment);
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromForm] AttachmentRequest request)
    {
        if (request.File.Length is 0)
            return BadRequest("File is required.");

        await attachmentService.AddAsync(request);
        return CreatedAtAction(nameof(Get), new { id = request.ExpenseId }, request);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromForm] AttachmentRequest request)
    {
        if (id != request.ExpenseId)
            return BadRequest("Mismatched ID");

        await attachmentService.UpdateAsync(request);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var existingAttachment = await attachmentService.GetAsync(id);

        await attachmentService.DeleteAsync(new AttachmentRequest { ExpenseId = id });
        return NoContent();
    }
}