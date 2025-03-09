using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.infrastructure.Common;

public class BaseEntity
{
    [Key]
    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string CreatedBy { get; set; }

    public string ModifiedBy { get; set; }
}