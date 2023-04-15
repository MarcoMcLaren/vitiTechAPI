using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class lsdmkejwjew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdminID",
                table: "EventLocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EventLocations_AdminID",
                table: "EventLocations",
                column: "AdminID");

            migrationBuilder.AddForeignKey(
                name: "FK_EventLocations_Admins_AdminID",
                table: "EventLocations",
                column: "AdminID",
                principalTable: "Admins",
                principalColumn: "AdminID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventLocations_Admins_AdminID",
                table: "EventLocations");

            migrationBuilder.DropIndex(
                name: "IX_EventLocations_AdminID",
                table: "EventLocations");

            migrationBuilder.DropColumn(
                name: "AdminID",
                table: "EventLocations");
        }
    }
}
