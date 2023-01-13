using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assign.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(name: "Category_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(name: "Category_Name", type: "nvarchar(max)", nullable: false),
                    CategoryLimit = table.Column<float>(name: "Category_Limit", type: "real", nullable: false),
                    CategoryDescription = table.Column<string>(name: "Category_Description", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    ExpenseId = table.Column<int>(name: "Expense_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpenseTitle = table.Column<string>(name: "Expense_Title", type: "nvarchar(max)", nullable: false),
                    ExpenseDescription = table.Column<string>(name: "Expense_Description", type: "nvarchar(max)", nullable: false),
                    ExpenseLimit = table.Column<int>(name: "Expense_Limit", type: "int", nullable: false),
                    CategoryId = table.Column<int>(name: "Category_Id", type: "int", nullable: false),
                    CategoryTitle = table.Column<string>(name: "Category_Title", type: "nvarchar(max)", nullable: false),
                    CategoryId1 = table.Column<int>(name: "Category_Id1", type: "int", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.ExpenseId);
                    table.ForeignKey(
                        name: "FK_Transactions_Categories_Category_Id1",
                        column: x => x.CategoryId1,
                        principalTable: "Categories",
                        principalColumn: "Category_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_Category_Id1",
                table: "Transactions",
                column: "Category_Id1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
