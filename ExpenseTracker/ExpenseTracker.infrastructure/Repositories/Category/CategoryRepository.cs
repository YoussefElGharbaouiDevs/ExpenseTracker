using ExpenseTracker.infrastructure.Models;
using ExpenseTracker.infrastructure.Repositories.Attachment;

namespace ExpenseTracker.infrastructure.Repositories.Category;

public class CategoryRepository(ExpenseTrackerDbContext context): GenericRepository<CategoryEntity>(context), ICategoryRepository 
{
    
}