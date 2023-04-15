using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class jsdhsbds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderItemID",
                table: "Wines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WineID",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_WineID",
                table: "OrderItems",
                column: "WineID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Wines_WineID",
                table: "OrderItems",
                column: "WineID",
                principalTable: "Wines",
                principalColumn: "WineID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Wines_WineID",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_WineID",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "OrderItemID",
                table: "Wines");

            migrationBuilder.DropColumn(
                name: "WineID",
                table: "OrderItems");
        }
    }
}
