using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class jshdhgd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_SuperUsers_SuperUserID",
                table: "Admins");

            migrationBuilder.DropIndex(
                name: "IX_Admins_SuperUserID",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "SuperUserID",
                table: "Admins");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SuperUserID",
                table: "Admins",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Admins_SuperUserID",
                table: "Admins",
                column: "SuperUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_SuperUsers_SuperUserID",
                table: "Admins",
                column: "SuperUserID",
                principalTable: "SuperUsers",
                principalColumn: "SuperUserID");
        }
    }
}
