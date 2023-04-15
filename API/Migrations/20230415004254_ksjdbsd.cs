using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ksjdbsd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VarietalID",
                table: "Wines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Wines_VarietalID",
                table: "Wines",
                column: "VarietalID");

            migrationBuilder.AddForeignKey(
                name: "FK_Wines_Varietals_VarietalID",
                table: "Wines",
                column: "VarietalID",
                principalTable: "Varietals",
                principalColumn: "VarietalID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wines_Varietals_VarietalID",
                table: "Wines");

            migrationBuilder.DropIndex(
                name: "IX_Wines_VarietalID",
                table: "Wines");

            migrationBuilder.DropColumn(
                name: "VarietalID",
                table: "Wines");
        }
    }
}
