using ExpenseTracker.infrastructure.Models.Common;

namespace ExpenseTracker.infrastructure.Models;

public class CategoryEntity : BaseEntity
{
    public string Name { get; set; }
    
    public double FileSize { get; set; }
    
    public ICollection<ExpenseEntity> Expenses { get; set; } = new List<ExpenseEntity>();
} 