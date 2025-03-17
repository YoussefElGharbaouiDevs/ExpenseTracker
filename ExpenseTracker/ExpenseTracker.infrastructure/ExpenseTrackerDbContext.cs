using ExpenseTracker.infrastructure.Models;
using ExpenseTracker.infrastructure.Models.Common;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.infrastructure;

public class ExpenseTrackerDbContext : DbContext
{
    public ExpenseTrackerDbContext(DbContextOptions<ExpenseTrackerDbContext> options) : base(options){}

    #region DbSets

    public virtual DbSet<CurrencyEntity> Currency { get; set; }
    
    public virtual DbSet<UserEntity> User { get; set; }
    
    public virtual DbSet<AttachmentEntity> Attachment { get; set; }
    
    public virtual DbSet<AttachmentTypeEntity> AttachmentType { get; set; }
    
    public virtual DbSet<CategoryEntity> Category { get; set; }
    
    public virtual DbSet<RecurrenceFrequencyEntity> RecurrenceFrequency { get; set; }
    
    public virtual DbSet<ExpenseEntity> Expense { get; set; }

    #endregion
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Ignore<BaseEntity>();

        modelBuilder.Entity<ExpenseEntity>(builder =>
        {
            builder.Property(p => p.Amount).HasPrecision(18, 2);
        });
    }
}