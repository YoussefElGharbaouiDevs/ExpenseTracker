using ExpenseTracker.infrastructure.Models;
using ExpenseTracker.infrastructure.Models.Common;
using ExpenseTracker.infrastructure.Repositories;
using ExpenseTracker.infrastructure.Repositories.Attachment;
using ExpenseTracker.infrastructure.Repositories.Category;
using ExpenseTracker.infrastructure.Repositories.Currency;
using ExpenseTracker.infrastructure.Repositories.Expense;
using ExpenseTracker.infrastructure.Repositories.RecurrenceFrequency;

namespace ExpenseTracker.api.Utils.Extensions;

public static  class RepositoryCollection
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IAttachmentRepository, AttachmentRepository>();
        services.AddScoped<IGenericRepository<AttachmentEntity>, GenericRepository<AttachmentEntity>>();

        services.AddScoped<IAttachmentTypeRepository, AttachmentTypeRepository>();
        services.AddScoped<IGenericRepository<AttachmentTypeEntity>, GenericRepository<AttachmentTypeEntity>>();

        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IGenericRepository<CategoryEntity>, GenericRepository<CategoryEntity>>();

        services.AddScoped<ICurrencyRepository, CurrencyRepository>();
        services.AddScoped<IGenericRepository<CurrencyEntity>, GenericRepository<CurrencyEntity>>();

        services.AddScoped<IRecurrenceFrequencyRepository, RecurrenceFrequencyRepository>();
        services.AddScoped<IGenericRepository<RecurrenceFrequencyEntity>, GenericRepository<RecurrenceFrequencyEntity>>();
        
        services.AddScoped<IExpenseRepository, ExpenseRepository>();
        services.AddScoped<IGenericRepository<ExpenseEntity>, GenericRepository<ExpenseEntity>>();
        
        return services;
    }
}