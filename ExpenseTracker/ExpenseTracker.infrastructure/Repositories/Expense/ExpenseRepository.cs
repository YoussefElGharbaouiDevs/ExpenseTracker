using ExpenseTracker.infrastructure.Models;

namespace ExpenseTracker.infrastructure.Repositories.Expense;

public class ExpenseRepository(ExpenseTrackerDbContext context) :GenericRepository<ExpenseEntity>(context), IExpenseRepository
{
    
}