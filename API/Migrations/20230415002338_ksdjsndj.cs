using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ksdjsndj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SupplierOrderID",
                table: "SupplierPayments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SupplierPaymentID",
                table: "SupplierOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPayments_SupplierOrderID",
                table: "SupplierPayments",
                column: "SupplierOrderID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierPayments_SupplierOrders_SupplierOrderID",
                table: "SupplierPayments",
                column: "SupplierOrderID",
                principalTable: "SupplierOrders",
                principalColumn: "SupplierOrderID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplierPayments_SupplierOrders_SupplierOrderID",
                table: "SupplierPayments");

            migrationBuilder.DropIndex(
                name: "IX_SupplierPayments_SupplierOrderID",
                table: "SupplierPayments");

            migrationBuilder.DropColumn(
                name: "SupplierOrderID",
                table: "SupplierPayments");

            migrationBuilder.DropColumn(
                name: "SupplierPaymentID",
                table: "SupplierOrders");
        }
    }
}
