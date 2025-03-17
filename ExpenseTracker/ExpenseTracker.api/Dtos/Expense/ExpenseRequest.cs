namespace ExpenseTracker.api.Dtos.Expense;

public class ExpenseRequest
{
    public decimal Amount { get; set; }
    
    public DateOnly Date { get; set; }
    
    public string Description { get; set; }
    
    public int CategoryId { get; set; } 
    
    public bool IsRecurring { get; set; }
    
    public int? RecurrenceFrequencyId { get; set; }
    
    public string UserId { get; set; }
    
    public string Currency { get; set; }
}