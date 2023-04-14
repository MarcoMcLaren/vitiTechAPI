using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ahhas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdminSuperUsers_Admins_AdminID",
                table: "AdminSuperUsers");

            migrationBuilder.DropIndex(
                name: "IX_AdminSuperUsers_AdminID",
                table: "AdminSuperUsers");

            migrationBuilder.AddColumn<int>(
                name: "AdminID1",
                table: "AdminSuperUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdminSuperUserID",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AdminSuperUsers_AdminID1",
                table: "AdminSuperUsers",
                column: "AdminID1");

            migrationBuilder.CreateIndex(
                name: "IX_Admins_AdminSuperUserID",
                table: "Admins",
                column: "AdminSuperUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Users_AdminSuperUserID",
                table: "Admins",
                column: "AdminSuperUserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AdminSuperUsers_Admins_AdminID1",
                table: "AdminSuperUsers",
                column: "AdminID1",
                principalTable: "Admins",
                principalColumn: "AdminID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Users_AdminSuperUserID",
                table: "Admins");

            migrationBuilder.DropForeignKey(
                name: "FK_AdminSuperUsers_Admins_AdminID1",
                table: "AdminSuperUsers");

            migrationBuilder.DropIndex(
                name: "IX_AdminSuperUsers_AdminID1",
                table: "AdminSuperUsers");

            migrationBuilder.DropIndex(
                name: "IX_Admins_AdminSuperUserID",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "AdminID1",
                table: "AdminSuperUsers");

            migrationBuilder.DropColumn(
                name: "AdminSuperUserID",
                table: "Admins");

            migrationBuilder.CreateIndex(
                name: "IX_AdminSuperUsers_AdminID",
                table: "AdminSuperUsers",
                column: "AdminID");

            migrationBuilder.AddForeignKey(
                name: "FK_AdminSuperUsers_Admins_AdminID",
                table: "AdminSuperUsers",
                column: "AdminID",
                principalTable: "Admins",
                principalColumn: "AdminID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
