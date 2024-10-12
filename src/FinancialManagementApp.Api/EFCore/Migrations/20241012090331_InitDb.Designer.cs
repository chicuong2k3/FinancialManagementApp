﻿// <auto-generated />
using System;
using FinancialManagementApp.Api.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinancialManagementApp.Api.EFCore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241012090331_InitDb")]
    partial class InitDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoryPayee", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("PayeesId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "PayeesId");

                    b.HasIndex("PayeesId");

                    b.ToTable("CategoryPayee");
                });

            modelBuilder.Entity("FinancialManagementApp.Api.Domain.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountTypeId")
                        .HasColumnType("int");

                    b.Property<double>("BalanceAsOfDate")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("StartingBalance")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("AccountTypeId");

                    b.HasIndex("Name");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("FinancialManagementApp.Api.Domain.Models.AccountType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("AccountTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cash",
                            SortOrder = 1
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified),
                            Name = "Checking",
                            SortOrder = 2
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified),
                            Name = "Savings",
                            SortOrder = 3
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified),
                            Name = "Credit Card",
                            SortOrder = 4
                        },
                        new
                        {
                            Id = 5,
                            IsDeleted = false,
                            LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified),
                            Name = "Debit Card",
                            SortOrder = 5
                        });
                });

            modelBuilder.Entity("FinancialManagementApp.Api.Domain.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified),
                            Name = "House",
                            SortOrder = 1
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified),
                            Name = "Grocery",
                            SortOrder = 2
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified),
                            Name = "Rental Apartment",
                            SortOrder = 3
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified),
                            Name = "Goods",
                            SortOrder = 4
                        },
                        new
                        {
                            Id = 5,
                            IsDeleted = false,
                            LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified),
                            Name = "Service",
                            SortOrder = 5
                        });
                });

            modelBuilder.Entity("FinancialManagementApp.Api.Domain.Models.LineItemType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("LineItemTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sub Total",
                            SortOrder = 1
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified),
                            Name = "Tax",
                            SortOrder = 2
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified),
                            Name = "Fee",
                            SortOrder = 3
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified),
                            Name = "Surcharge",
                            SortOrder = 4
                        },
                        new
                        {
                            Id = 5,
                            IsDeleted = false,
                            LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified),
                            Name = "Service",
                            SortOrder = 5
                        });
                });

            modelBuilder.Entity("FinancialManagementApp.Api.Domain.Models.Payee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Payees");
                });

            modelBuilder.Entity("FinancialManagementApp.Api.Domain.Models.RecurrenceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DisplayText")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SortOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DisplayText");

                    b.ToTable("RecurrenceTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayText = "Một lần",
                            IsDeleted = false,
                            LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified),
                            Name = "OneTime",
                            SortOrder = 1
                        },
                        new
                        {
                            Id = 2,
                            DisplayText = "Hàng ngày",
                            IsDeleted = false,
                            LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified),
                            Name = "Daily",
                            SortOrder = 2
                        },
                        new
                        {
                            Id = 3,
                            DisplayText = "Hàng tuần",
                            IsDeleted = false,
                            LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified),
                            Name = "Weekly",
                            SortOrder = 3
                        },
                        new
                        {
                            Id = 4,
                            DisplayText = "Hai tuần một lần",
                            IsDeleted = false,
                            LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified),
                            Name = "BiWeekly",
                            SortOrder = 4
                        },
                        new
                        {
                            Id = 5,
                            DisplayText = "Hàng tháng",
                            IsDeleted = false,
                            LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified),
                            Name = "Monthly",
                            SortOrder = 5
                        },
                        new
                        {
                            Id = 6,
                            DisplayText = "Hai tháng một lần",
                            IsDeleted = false,
                            LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified),
                            Name = "BiMonthly",
                            SortOrder = 6
                        },
                        new
                        {
                            Id = 7,
                            DisplayText = "Hàng quý",
                            IsDeleted = false,
                            LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified),
                            Name = "Quarterly",
                            SortOrder = 7
                        },
                        new
                        {
                            Id = 8,
                            DisplayText = "Nửa năm một lần",
                            IsDeleted = false,
                            LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified),
                            Name = "SemiAnnually",
                            SortOrder = 8
                        },
                        new
                        {
                            Id = 9,
                            DisplayText = "Hàng năm",
                            IsDeleted = false,
                            LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified),
                            Name = "Annually",
                            SortOrder = 9
                        },
                        new
                        {
                            Id = 10,
                            DisplayText = "Tùy chỉnh",
                            IsDeleted = false,
                            LastUpdated = new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified),
                            Name = "Custom",
                            SortOrder = 10
                        });
                });

            modelBuilder.Entity("FinancialManagementApp.Api.Domain.Models.ScheduledTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("PayeeId")
                        .HasColumnType("int");

                    b.Property<int>("RecurrenceTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("PayeeId");

                    b.HasIndex("RecurrenceTypeId");

                    b.ToTable("ScheduledTransactions");
                });

            modelBuilder.Entity("FinancialManagementApp.Api.Domain.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateEntered")
                        .HasColumnType("datetime2");

                    b.Property<string>("Memo")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("PayeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("PayeeId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("FinancialManagementApp.Api.Domain.Models.TransactionDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("LineItemTypeId")
                        .HasColumnType("int");

                    b.Property<int>("TransactionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LineItemTypeId");

                    b.HasIndex("TransactionId");

                    b.ToTable("TransactionDetails");
                });

            modelBuilder.Entity("FinancialManagementApp.Api.Domain.Models.Transfer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("TransactionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("TransactionId")
                        .IsUnique();

                    b.ToTable("Transfers");
                });

            modelBuilder.Entity("CategoryPayee", b =>
                {
                    b.HasOne("FinancialManagementApp.Api.Domain.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinancialManagementApp.Api.Domain.Models.Payee", null)
                        .WithMany()
                        .HasForeignKey("PayeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FinancialManagementApp.Api.Domain.Models.Account", b =>
                {
                    b.HasOne("FinancialManagementApp.Api.Domain.Models.AccountType", "AccountType")
                        .WithMany("Accounts")
                        .HasForeignKey("AccountTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountType");
                });

            modelBuilder.Entity("FinancialManagementApp.Api.Domain.Models.ScheduledTransaction", b =>
                {
                    b.HasOne("FinancialManagementApp.Api.Domain.Models.Account", "Account")
                        .WithMany("ScheduledTransactions")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinancialManagementApp.Api.Domain.Models.Payee", "Payee")
                        .WithMany("ScheduledTransactions")
                        .HasForeignKey("PayeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinancialManagementApp.Api.Domain.Models.RecurrenceType", "RecurrenceType")
                        .WithMany("ScheduledTransactions")
                        .HasForeignKey("RecurrenceTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Payee");

                    b.Navigation("RecurrenceType");
                });

            modelBuilder.Entity("FinancialManagementApp.Api.Domain.Models.Transaction", b =>
                {
                    b.HasOne("FinancialManagementApp.Api.Domain.Models.Account", "Account")
                        .WithMany("Transactions")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinancialManagementApp.Api.Domain.Models.Payee", "Payee")
                        .WithMany("Transactions")
                        .HasForeignKey("PayeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Payee");
                });

            modelBuilder.Entity("FinancialManagementApp.Api.Domain.Models.TransactionDetail", b =>
                {
                    b.HasOne("FinancialManagementApp.Api.Domain.Models.LineItemType", "LineItemType")
                        .WithMany("TransactionDetails")
                        .HasForeignKey("LineItemTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinancialManagementApp.Api.Domain.Models.Transaction", "Transaction")
                        .WithMany("TransactionDetails")
                        .HasForeignKey("TransactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LineItemType");

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("FinancialManagementApp.Api.Domain.Models.Transfer", b =>
                {
                    b.HasOne("FinancialManagementApp.Api.Domain.Models.Account", "Account")
                        .WithMany("Transfers")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinancialManagementApp.Api.Domain.Models.Transaction", "Transaction")
                        .WithOne("Transfer")
                        .HasForeignKey("FinancialManagementApp.Api.Domain.Models.Transfer", "TransactionId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Account");

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("FinancialManagementApp.Api.Domain.Models.Account", b =>
                {
                    b.Navigation("ScheduledTransactions");

                    b.Navigation("Transactions");

                    b.Navigation("Transfers");
                });

            modelBuilder.Entity("FinancialManagementApp.Api.Domain.Models.AccountType", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("FinancialManagementApp.Api.Domain.Models.LineItemType", b =>
                {
                    b.Navigation("TransactionDetails");
                });

            modelBuilder.Entity("FinancialManagementApp.Api.Domain.Models.Payee", b =>
                {
                    b.Navigation("ScheduledTransactions");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("FinancialManagementApp.Api.Domain.Models.RecurrenceType", b =>
                {
                    b.Navigation("ScheduledTransactions");
                });

            modelBuilder.Entity("FinancialManagementApp.Api.Domain.Models.Transaction", b =>
                {
                    b.Navigation("TransactionDetails");

                    b.Navigation("Transfer");
                });
#pragma warning restore 612, 618
        }
    }
}
