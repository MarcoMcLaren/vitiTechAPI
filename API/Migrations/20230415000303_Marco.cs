using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class Marco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WineID",
                table: "SupplierOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SupplierOrders_WineID",
                table: "SupplierOrders",
                column: "WineID");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierOrders_Wines_WineID",
                table: "SupplierOrders",
                column: "WineID",
                principalTable: "Wines",
                principalColumn: "WineID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplierOrders_Wines_WineID",
                table: "SupplierOrders");

            migrationBuilder.DropIndex(
                name: "IX_SupplierOrders_WineID",
                table: "SupplierOrders");

            migrationBuilder.DropColumn(
                name: "WineID",
                table: "SupplierOrders");
        }
    }
}
