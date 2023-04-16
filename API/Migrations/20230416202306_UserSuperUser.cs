using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class UserSuperUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "SuperUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SuperUser_UserID",
                table: "SuperUser",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_SuperUser_Users_UserID",
                table: "SuperUser",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SuperUser_Users_UserID",
                table: "SuperUser");

            migrationBuilder.DropIndex(
                name: "IX_SuperUser_UserID",
                table: "SuperUser");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "SuperUser");
        }
    }
}
