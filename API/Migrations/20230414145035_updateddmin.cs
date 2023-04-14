using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class updateddmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_AdminSuperUsers_AdminSuperUserID",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_Admins_SuperUsers_SuperUserID",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_SuperUsers_AdminSuperUsers_AdminSuperUserID",
                table: "SuperUsers");

            migrationBuilder.DropIndex(
                name: "IX_SuperUsers_AdminSuperUserID",
                table: "SuperUsers");

            migrationBuilder.DropIndex(
                name: "IX_Admins_AdminSuperUserID",
                table: "Admins");

            migrationBuilder.DropIndex(
                name: "IX_Admins_SuperUserID",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "AdminSuperUserID",
                table: "SuperUsers");

            migrationBuilder.DropColumn(
                name: "AdminSuperUserID",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "SuperUserID",
                table: "Admins");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdminSuperUserID",
                table: "SuperUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdminSuperUserID",
                table: "Admins",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SuperUserID",
                table: "Admins",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SuperUsers_AdminSuperUserID",
                table: "SuperUsers",
                column: "AdminSuperUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Admins_AdminSuperUserID",
                table: "Admins",
                column: "AdminSuperUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Admins_SuperUserID",
                table: "Admins",
                column: "SuperUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_AdminSuperUsers_AdminSuperUserID",
                table: "Admins",
                column: "AdminSuperUserID",
                principalTable: "AdminSuperUsers",
                principalColumn: "AdminSuperUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_SuperUsers_SuperUserID",
                table: "Admins",
                column: "SuperUserID",
                principalTable: "SuperUsers",
                principalColumn: "SuperUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_SuperUsers_AdminSuperUsers_AdminSuperUserID",
                table: "SuperUsers",
                column: "AdminSuperUserID",
                principalTable: "AdminSuperUsers",
                principalColumn: "AdminSuperUserID");
        }
    }
}
