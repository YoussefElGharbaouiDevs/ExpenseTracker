using ExpenseTracker.infrastructure.Models.Common;

namespace ExpenseTracker.infrastructure.Repositories.Currency;

public class CurrencyRepository(ExpenseTrackerDbContext context) : GenericRepository<CurrencyEntity>(context), ICurrencyRepository
{
    
}