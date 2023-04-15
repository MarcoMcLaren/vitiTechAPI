using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class kdjdjsd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiscountID",
                table: "WineDiscounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WineDiscounts_DiscountID",
                table: "WineDiscounts",
                column: "DiscountID");

            migrationBuilder.AddForeignKey(
                name: "FK_WineDiscounts_Discounts_DiscountID",
                table: "WineDiscounts",
                column: "DiscountID",
                principalTable: "Discounts",
                principalColumn: "DiscountID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WineDiscounts_Discounts_DiscountID",
                table: "WineDiscounts");

            migrationBuilder.DropIndex(
                name: "IX_WineDiscounts_DiscountID",
                table: "WineDiscounts");

            migrationBuilder.DropColumn(
                name: "DiscountID",
                table: "WineDiscounts");
        }
    }
}
