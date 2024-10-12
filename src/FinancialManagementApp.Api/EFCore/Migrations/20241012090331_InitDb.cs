using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinancialManagementApp.Api.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class InitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LineItemTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineItemTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecurrenceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DisplayText = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecurrenceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartingBalance = table.Column<double>(type: "float", nullable: false),
                    BalanceAsOfDate = table.Column<double>(type: "float", nullable: false),
                    AccountTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_AccountTypes_AccountTypeId",
                        column: x => x.AccountTypeId,
                        principalTable: "AccountTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryPayee",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    PayeesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryPayee", x => new { x.CategoriesId, x.PayeesId });
                    table.ForeignKey(
                        name: "FK_CategoryPayee_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryPayee_Payees_PayeesId",
                        column: x => x.PayeesId,
                        principalTable: "Payees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScheduledTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    PayeeId = table.Column<int>(type: "int", nullable: false),
                    RecurrenceTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduledTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduledTransactions_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduledTransactions_Payees_PayeeId",
                        column: x => x.PayeeId,
                        principalTable: "Payees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduledTransactions_RecurrenceTypes_RecurrenceTypeId",
                        column: x => x.RecurrenceTypeId,
                        principalTable: "RecurrenceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    PayeeId = table.Column<int>(type: "int", nullable: false),
                    DateEntered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Memo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transactions_Payees_PayeeId",
                        column: x => x.PayeeId,
                        principalTable: "Payees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransactionDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TransactionId = table.Column<int>(type: "int", nullable: false),
                    LineItemTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransactionDetails_LineItemTypes_LineItemTypeId",
                        column: x => x.LineItemTypeId,
                        principalTable: "LineItemTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactionDetails_Transactions_TransactionId",
                        column: x => x.TransactionId,
                        principalTable: "Transactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transfers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionId = table.Column<int>(type: "int", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transfers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transfers_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transfers_Transactions_TransactionId",
                        column: x => x.TransactionId,
                        principalTable: "Transactions",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AccountTypes",
                columns: new[] { "Id", "IsDeleted", "LastUpdated", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified), "Cash", 1 },
                    { 2, false, new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified), "Checking", 2 },
                    { 3, false, new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified), "Savings", 3 },
                    { 4, false, new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified), "Credit Card", 4 },
                    { 5, false, new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified), "Debit Card", 5 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsDeleted", "LastUpdated", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified), "House", 1 },
                    { 2, false, new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified), "Grocery", 2 },
                    { 3, false, new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified), "Rental Apartment", 3 },
                    { 4, false, new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified), "Goods", 4 },
                    { 5, false, new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified), "Service", 5 }
                });

            migrationBuilder.InsertData(
                table: "LineItemTypes",
                columns: new[] { "Id", "IsDeleted", "LastUpdated", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, false, new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified), "Sub Total", 1 },
                    { 2, false, new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified), "Tax", 2 },
                    { 3, false, new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified), "Fee", 3 },
                    { 4, false, new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified), "Surcharge", 4 },
                    { 5, false, new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified), "Service", 5 }
                });

            migrationBuilder.InsertData(
                table: "RecurrenceTypes",
                columns: new[] { "Id", "DisplayText", "IsDeleted", "LastUpdated", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, "Một lần", false, new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified), "OneTime", 1 },
                    { 2, "Hàng ngày", false, new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified), "Daily", 2 },
                    { 3, "Hàng tuần", false, new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified), "Weekly", 3 },
                    { 4, "Hai tuần một lần", false, new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified), "BiWeekly", 4 },
                    { 5, "Hàng tháng", false, new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified), "Monthly", 5 },
                    { 6, "Hai tháng một lần", false, new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified), "BiMonthly", 6 },
                    { 7, "Hàng quý", false, new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified), "Quarterly", 7 },
                    { 8, "Nửa năm một lần", false, new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified), "SemiAnnually", 8 },
                    { 9, "Hàng năm", false, new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified), "Annually", 9 },
                    { 10, "Tùy chỉnh", false, new DateTime(2024, 7, 8, 3, 30, 0, 0, DateTimeKind.Unspecified), "Custom", 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_AccountTypeId",
                table: "Accounts",
                column: "AccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_Name",
                table: "Accounts",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_AccountTypes_Name",
                table: "AccountTypes",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryPayee_PayeesId",
                table: "CategoryPayee",
                column: "PayeesId");

            migrationBuilder.CreateIndex(
                name: "IX_LineItemTypes_Name",
                table: "LineItemTypes",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Payees_Name",
                table: "Payees",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_RecurrenceTypes_DisplayText",
                table: "RecurrenceTypes",
                column: "DisplayText");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduledTransactions_AccountId",
                table: "ScheduledTransactions",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduledTransactions_PayeeId",
                table: "ScheduledTransactions",
                column: "PayeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduledTransactions_RecurrenceTypeId",
                table: "ScheduledTransactions",
                column: "RecurrenceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionDetails_LineItemTypeId",
                table: "TransactionDetails",
                column: "LineItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionDetails_TransactionId",
                table: "TransactionDetails",
                column: "TransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_AccountId",
                table: "Transactions",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_PayeeId",
                table: "Transactions",
                column: "PayeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_AccountId",
                table: "Transfers",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_TransactionId",
                table: "Transfers",
                column: "TransactionId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryPayee");

            migrationBuilder.DropTable(
                name: "ScheduledTransactions");

            migrationBuilder.DropTable(
                name: "TransactionDetails");

            migrationBuilder.DropTable(
                name: "Transfers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "RecurrenceTypes");

            migrationBuilder.DropTable(
                name: "LineItemTypes");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Payees");

            migrationBuilder.DropTable(
                name: "AccountTypes");
        }
    }
}
