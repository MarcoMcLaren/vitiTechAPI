using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class klsdjksdjs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderID",
                table: "ShippingDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShippingID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderID",
                table: "OrderPayments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ShippingDetails_OrderID",
                table: "ShippingDetails",
                column: "OrderID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderPayments_OrderID",
                table: "OrderPayments",
                column: "OrderID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderPayments_Orders_OrderID",
                table: "OrderPayments",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShippingDetails_Orders_OrderID",
                table: "ShippingDetails",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderPayments_Orders_OrderID",
                table: "OrderPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_ShippingDetails_Orders_OrderID",
                table: "ShippingDetails");

            migrationBuilder.DropIndex(
                name: "IX_ShippingDetails_OrderID",
                table: "ShippingDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderPayments_OrderID",
                table: "OrderPayments");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "ShippingDetails");

            migrationBuilder.DropColumn(
                name: "ShippingID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "OrderPayments");
        }
    }
}
