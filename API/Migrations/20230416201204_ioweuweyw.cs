using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ioweuweyw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventReviews_Customers_CustomerId",
                table: "EventReviews");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "EventReviews",
                newName: "CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_EventReviews_CustomerId",
                table: "EventReviews",
                newName: "IX_EventReviews_CustomerID");

            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_CustomerID",
                table: "Users",
                column: "CustomerID");

            migrationBuilder.AddForeignKey(
                name: "FK_EventReviews_Customers_CustomerID",
                table: "EventReviews",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Customers_CustomerID",
                table: "Users",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventReviews_Customers_CustomerID",
                table: "EventReviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Customers_CustomerID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CustomerID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "EventReviews",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_EventReviews_CustomerID",
                table: "EventReviews",
                newName: "IX_EventReviews_CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventReviews_Customers_CustomerId",
                table: "EventReviews",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerID");
        }
    }
}
