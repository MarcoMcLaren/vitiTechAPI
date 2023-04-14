using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class dsjhdhbfbdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_SuperUsers_SuperUserID",
                table: "Admins");

            migrationBuilder.AlterColumn<int>(
                name: "SuperUserID",
                table: "Admins",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_SuperUsers_SuperUserID",
                table: "Admins",
                column: "SuperUserID",
                principalTable: "SuperUsers",
                principalColumn: "SuperUserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_SuperUsers_SuperUserID",
                table: "Admins");

            migrationBuilder.AlterColumn<int>(
                name: "SuperUserID",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_SuperUsers_SuperUserID",
                table: "Admins",
                column: "SuperUserID",
                principalTable: "SuperUsers",
                principalColumn: "SuperUserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
