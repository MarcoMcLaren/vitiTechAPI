using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class knjdsdjsd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderItemID",
                table: "Refunds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Refunds_OrderItemID",
                table: "Refunds",
                column: "OrderItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_Refunds_OrderItems_OrderItemID",
                table: "Refunds",
                column: "OrderItemID",
                principalTable: "OrderItems",
                principalColumn: "OrderItemID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Refunds_OrderItems_OrderItemID",
                table: "Refunds");

            migrationBuilder.DropIndex(
                name: "IX_Refunds_OrderItemID",
                table: "Refunds");

            migrationBuilder.DropColumn(
                name: "OrderItemID",
                table: "Refunds");
        }
    }
}
