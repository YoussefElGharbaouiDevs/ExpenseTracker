using ExpenseTracker.infrastructure.Common;

namespace ExpenseTracker.infrastructure;

public class RecurrenceFrequency : BaseEntity
{
    public string Name { get; set; }

    public virtual ICollection<ExpenseEntity> Expenses { get; set; } = new List<ExpenseEntity>();
}