using ExpenseTracker.infrastructure.Models;

namespace ExpenseTracker.infrastructure.Repositories.RecurrenceFrequency;

public class RecurrenceFrequencyRepository(ExpenseTrackerDbContext context) : GenericRepository<RecurrenceFrequencyEntity>(context), IRecurrenceFrequencyRepository
{
    
}