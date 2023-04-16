using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class CustomerEventreview : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "EventReviews",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EventReviews_CustomerId",
                table: "EventReviews",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventReviews_Customers_CustomerId",
                table: "EventReviews",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventReviews_Customers_CustomerId",
                table: "EventReviews");

            migrationBuilder.DropIndex(
                name: "IX_EventReviews_CustomerId",
                table: "EventReviews");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "EventReviews");
        }
    }
}
