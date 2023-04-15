using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class kjsdjsds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WinePriceID",
                table: "Wines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WineID",
                table: "WinePrices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WinePrices_WineID",
                table: "WinePrices",
                column: "WineID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_WinePrices_Wines_WineID",
                table: "WinePrices",
                column: "WineID",
                principalTable: "Wines",
                principalColumn: "WineID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WinePrices_Wines_WineID",
                table: "WinePrices");

            migrationBuilder.DropIndex(
                name: "IX_WinePrices_WineID",
                table: "WinePrices");

            migrationBuilder.DropColumn(
                name: "WinePriceID",
                table: "Wines");

            migrationBuilder.DropColumn(
                name: "WineID",
                table: "WinePrices");
        }
    }
}
