using AutoMapper;
using ExpenseTracker.api.Dtos.Attachment;
using ExpenseTracker.api.Dtos.Category;
using ExpenseTracker.api.Dtos.Expense;
using ExpenseTracker.api.Dtos.RecurrenceFequency;
using ExpenseTracker.infrastructure.Models;

namespace ExpenseTracker.api.Configuration;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<AttachmentRequest, AttachmentEntity>().ReverseMap();
        CreateMap<AttachmentEntity, AttachmentResponse>().ReverseMap();
        CreateMap<ExpenseEntity, ExpenseResponse>().ReverseMap();
        CreateMap<ExpenseRequest, ExpenseEntity>().ReverseMap();
        CreateMap<CategoryEntity, CategoryResponse>().ReverseMap();
        CreateMap<CategoryRequest, CategoryEntity>().ReverseMap();
        CreateMap<RecurrenceFrequencyEntity, RecurrenceFrequencyResponse>().ReverseMap();
        CreateMap<RecurrenceFrequencyRequest, RecurrenceFrequencyEntity>().ReverseMap();
    }
}