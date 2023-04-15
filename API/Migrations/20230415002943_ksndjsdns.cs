using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ksndjsdns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WineTypeID",
                table: "Wines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Wines_WineTypeID",
                table: "Wines",
                column: "WineTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Wines_WineTypes_WineTypeID",
                table: "Wines",
                column: "WineTypeID",
                principalTable: "WineTypes",
                principalColumn: "WineTypeID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wines_WineTypes_WineTypeID",
                table: "Wines");

            migrationBuilder.DropIndex(
                name: "IX_Wines_WineTypeID",
                table: "Wines");

            migrationBuilder.DropColumn(
                name: "WineTypeID",
                table: "Wines");
        }
    }
}
