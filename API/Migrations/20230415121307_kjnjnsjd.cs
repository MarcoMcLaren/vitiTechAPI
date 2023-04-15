using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class kjnjnsjd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdminID",
                table: "Wines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Wines_AdminID",
                table: "Wines",
                column: "AdminID");

            migrationBuilder.AddForeignKey(
                name: "FK_Wines_Admins_AdminID",
                table: "Wines",
                column: "AdminID",
                principalTable: "Admins",
                principalColumn: "AdminID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wines_Admins_AdminID",
                table: "Wines");

            migrationBuilder.DropIndex(
                name: "IX_Wines_AdminID",
                table: "Wines");

            migrationBuilder.DropColumn(
                name: "AdminID",
                table: "Wines");
        }
    }
}
