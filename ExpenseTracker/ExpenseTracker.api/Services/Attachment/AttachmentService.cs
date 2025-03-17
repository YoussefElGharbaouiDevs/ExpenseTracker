using AutoMapper;
using ExpenseTracker.api.Dtos.Attachment;
using ExpenseTracker.api.Exceptions;
using ExpenseTracker.infrastructure.Models;
using ExpenseTracker.infrastructure.Repositories.Attachment;
using ExpenseTracker.infrastructure.Repositories.User;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.api.Services.Attachment;

public class AttachmentService(IAttachmentRepository attachmentRepository, IMapper mapper) : IAttachmentService
{
    private readonly IAttachmentRepository _attachmentRepository = attachmentRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<IEnumerable<AttachmentResponse>> GetAllAsync()
    {
        var attachments = await _attachmentRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<AttachmentResponse>>(attachments);
    }

    public async Task<ActionResult<AttachmentResponse>> GetAsync(int id)
    {
        var attachment = await _attachmentRepository.GetByIdAsync(id);
        if (attachment == null)
            return new NotFoundResult();

        return _mapper.Map<AttachmentResponse>(attachment);
    }

    public async Task AddAsync(AttachmentRequest entityDto)
    {
        var attachmentEntity = _mapper.Map<AttachmentEntity>(entityDto);
        await _attachmentRepository.AddAsync(attachmentEntity);
    }

    public async Task UpdateAsync(AttachmentRequest entityDto)
    {
        var existingAttachment = await _attachmentRepository.GetByIdAsync(entityDto.ExpenseId);
        if (existingAttachment == null)
            throw new AttachmentNotFoundException();

        _mapper.Map(entityDto, existingAttachment);
        await _attachmentRepository.UpdateAsync(existingAttachment);
    }

    public async Task DeleteAsync(AttachmentRequest entityDto)
    {
        var attachment = await _attachmentRepository.GetByIdAsync(entityDto.ExpenseId);
        if (attachment == null)
            throw new AttachmentNotFoundException();

        await _attachmentRepository.DeleteAsync(attachment);
    }
}
