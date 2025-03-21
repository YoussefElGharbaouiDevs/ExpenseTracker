﻿using ExpenseTracker.infrastructure.Models.Common;

namespace ExpenseTracker.infrastructure.Models;

public class RecurrenceFrequencyEntity : BaseEntity
{
    public string Name { get; set; }

    public virtual ICollection<ExpenseEntity> Expenses { get; set; } = new List<ExpenseEntity>();
}