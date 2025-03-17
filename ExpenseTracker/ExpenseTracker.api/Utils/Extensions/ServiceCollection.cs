using ExpenseTracker.api.Services.Attachment;
using ExpenseTracker.api.Services.Category;
using ExpenseTracker.api.Services.Currency;
using ExpenseTracker.api.Services.Expense;
using ExpenseTracker.api.Services.ReccurenceFrequency;
using ExpenseTracker.api.Services.RecurrenceFrequency;
using ExpenseTracker.api.Services.User;

namespace ExpenseTracker.api.Utils.Extensions;

public static class ServiceCollection
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IAttachmentService, AttachmentService>();
        services.AddScoped<IAttachmentTypeService, AttachmentTypeService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IExpenseService, ExpenseService>();
        services.AddScoped<ICurrencyService, CurrencyService>();
        services.AddScoped<IRecurrenceFrequencyService, RecurrenceFrequencyService>();
        services.AddScoped<IUserService, UserService>();
        
        return services;
    }
}