using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class jsbdsbd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WineID",
                table: "WriteOffItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WriteOffItems_WineID",
                table: "WriteOffItems",
                column: "WineID");

            migrationBuilder.AddForeignKey(
                name: "FK_WriteOffItems_Wines_WineID",
                table: "WriteOffItems",
                column: "WineID",
                principalTable: "Wines",
                principalColumn: "WineID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WriteOffItems_Wines_WineID",
                table: "WriteOffItems");

            migrationBuilder.DropIndex(
                name: "IX_WriteOffItems_WineID",
                table: "WriteOffItems");

            migrationBuilder.DropColumn(
                name: "WineID",
                table: "WriteOffItems");
        }
    }
}
