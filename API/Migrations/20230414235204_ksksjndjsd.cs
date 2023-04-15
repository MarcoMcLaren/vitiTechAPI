using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ksksjndjsd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WineID",
                table: "WineDiscounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WineDiscounts_WineID",
                table: "WineDiscounts",
                column: "WineID");

            migrationBuilder.AddForeignKey(
                name: "FK_WineDiscounts_Wines_WineID",
                table: "WineDiscounts",
                column: "WineID",
                principalTable: "Wines",
                principalColumn: "WineID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WineDiscounts_Wines_WineID",
                table: "WineDiscounts");

            migrationBuilder.DropIndex(
                name: "IX_WineDiscounts_WineID",
                table: "WineDiscounts");

            migrationBuilder.DropColumn(
                name: "WineID",
                table: "WineDiscounts");
        }
    }
}
