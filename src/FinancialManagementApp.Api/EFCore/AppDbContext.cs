using FinancialManagementApp.Api.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FinancialManagementApp.Api.EFCore;

public class AppDbContext : DbContext
{
    #region Constructors
    protected AppDbContext() { }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    #endregion

    #region Tables Declaration
    public DbSet<Account> Accounts { get; set; }
    public DbSet<AccountType> AccountTypes { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<LineItemType> LineItemTypes { get; set; }
    public DbSet<Payee> Payees { get; set; }
    public DbSet<RecurrenceType> RecurrenceTypes { get; set; }
    public DbSet<ScheduledTransaction> ScheduledTransactions { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<TransactionDetail> TransactionDetails { get; set; }
    public DbSet<Transfer> Transfers { get; set; }
    #endregion


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        #region Table Configuration
        modelBuilder.Entity<Account>().Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(100);

        modelBuilder.Entity<Account>().HasIndex(e => e.Name);

        modelBuilder.Entity<AccountType>().Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(50);

        modelBuilder.Entity<AccountType>().HasIndex(e => e.Name);

        modelBuilder.Entity<Category>().Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(50);

        modelBuilder.Entity<Category>().HasIndex(e => e.Name);

        modelBuilder.Entity<LineItemType>().Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(50);

        modelBuilder.Entity<LineItemType>().HasIndex(e => e.Name);

        modelBuilder.Entity<Payee>().Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(100);

        modelBuilder.Entity<Payee>().HasIndex(e => e.Name);

        modelBuilder.Entity<RecurrenceType>().Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(50);

        modelBuilder.Entity<RecurrenceType>().Property(e => e.DisplayText)
            .IsRequired()
            .HasMaxLength(50);

        modelBuilder.Entity<RecurrenceType>().HasIndex(e => e.DisplayText);

        modelBuilder.Entity<Transaction>(buildAction =>
        {
            buildAction.Property(e => e.Memo)
                    .HasMaxLength(250);

            
        });

        modelBuilder.Entity<TransactionDetail>().Property(e => e.Description)
            .HasMaxLength(250);


        modelBuilder.Entity<Transfer>(buildAction =>
        {
            buildAction.HasOne(e => e.Transaction)
                    .WithOne(e => e.Transfer)
                    .IsRequired(false)
                    .OnDelete(DeleteBehavior.NoAction);

            buildAction.HasOne(e => e.Account)
                    .WithMany(e => e.Transfers)
                    .OnDelete(DeleteBehavior.NoAction);
        });

        #endregion

        #region Seeding
        modelBuilder.SeedData();
        #endregion
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {

        var entities = ChangeTracker.Entries()
                        .Where(e => e.State == EntityState.Added && e.State == EntityState.Modified)
                        .Select(e => e.Entity)
                        .OfType<ILookupItem>();

        foreach (var entity in entities)
        {
            var lookupItem = entity as LookupItemBase;
            lookupItem!.LastUpdated = DateTime.UtcNow;
        }
            
        return base.SaveChangesAsync(cancellationToken);
    }

}
