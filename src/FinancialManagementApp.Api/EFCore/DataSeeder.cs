using FinancialManagementApp.Api.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FinancialManagementApp.Api.EFCore;

public static class DataSeeder
{
    public static void SeedData(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountType>().HasData(
            new AccountType()
            {
                Id = 1,
                Name = "Cash",
                SortOrder = 1,
                LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0),
                IsDeleted = false
            },
            new AccountType()
            {
                Id = 2,
                Name = "Checking",
                SortOrder = 2,
                LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0),
                IsDeleted = false
            },
            new AccountType()
            {
                Id = 3,
                Name = "Savings",
                SortOrder = 3,
                LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0),
                IsDeleted = false
            },
            new AccountType()
            {
                Id = 4,
                Name = "Credit Card",
                SortOrder = 4,
                LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0),
                IsDeleted = false
            },
            new AccountType()
            {
                Id = 5,
                Name = "Debit Card",
                SortOrder = 5,
                LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0),
                IsDeleted = false
            }
        );

        modelBuilder.Entity<Category>().HasData(
            new Category()
            {
                Id = 1,
                Name = "House",
                SortOrder = 1,
                LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0),
                IsDeleted = false
            },
            new Category()
            {
                Id = 2,
                Name = "Grocery",
                SortOrder = 2,
                LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0),
                IsDeleted = false
            },
            new Category()
            {
                Id = 3,
                Name = "Rental Apartment",
                SortOrder = 3,
                LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0),
                IsDeleted = false
            },
            new Category()
            {
                Id = 4,
                Name = "Goods",
                SortOrder = 4,
                LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0),
                IsDeleted = false
            },
            new Category()
            {
                Id = 5,
                Name = "Service",
                SortOrder = 5,
                LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0),
                IsDeleted = false
            }
        );

        modelBuilder.Entity<LineItemType>().HasData(
            new LineItemType()
            {
                Id = 1,
                Name = "Sub Total",
                SortOrder = 1,
                LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0),
                IsDeleted = false
            },
            new LineItemType()
            {
                Id = 2,
                Name = "Tax",
                SortOrder = 2,
                LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0),
                IsDeleted = false
            },
            new LineItemType()
            {
                Id = 3,
                Name = "Fee",
                SortOrder = 3,
                LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0),
                IsDeleted = false
            },
            new LineItemType()
            {
                Id = 4,
                Name = "Surcharge",
                SortOrder = 4,
                LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0),
                IsDeleted = false
            },
            new LineItemType()
            {
                Id = 5,
                Name = "Service",
                SortOrder = 5,
                LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0),
                IsDeleted = false
            }
        );

        int sortOrder = 1;
        modelBuilder.Entity<RecurrenceType>().HasData(
            Enum.GetValues<RecurrenceTypeEnum>().Select(x =>
                new RecurrenceType()
                {
                    Id = (int)x,
                    Name = x.ToString(),
                    DisplayText = x.GetDisplayText(),
                    SortOrder = sortOrder++,
                    LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0),
                    IsDeleted = false
                })
        );
    }
}
