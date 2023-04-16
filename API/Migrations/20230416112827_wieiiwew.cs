using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class wieiiwew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdminID",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Events_AdminID",
                table: "Events",
                column: "AdminID");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Admins_AdminID",
                table: "Events",
                column: "AdminID",
                principalTable: "Admins",
                principalColumn: "AdminID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Admins_AdminID",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_AdminID",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "AdminID",
                table: "Events");
        }
    }
}
