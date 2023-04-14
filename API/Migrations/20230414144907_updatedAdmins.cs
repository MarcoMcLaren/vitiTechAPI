using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class updatedAdmins : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_SuperUsers_SuperUserID",
                table: "Admins");

            migrationBuilder.AddColumn<int>(
                name: "AdminSuperUserID",
                table: "SuperUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SuperUserID",
                table: "Admins",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AdminSuperUserID",
                table: "Admins",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AdminSuperUsers",
                columns: table => new
                {
                    AdminSuperUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminID = table.Column<int>(type: "int", nullable: false),
                    SuperUserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminSuperUsers", x => x.AdminSuperUserID);
                    table.ForeignKey(
                        name: "FK_AdminSuperUsers_Admins_AdminID",
                        column: x => x.AdminID,
                        principalTable: "Admins",
                        principalColumn: "AdminID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminSuperUsers_SuperUsers_SuperUserID",
                        column: x => x.SuperUserID,
                        principalTable: "SuperUsers",
                        principalColumn: "SuperUserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SuperUsers_AdminSuperUserID",
                table: "SuperUsers",
                column: "AdminSuperUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Admins_AdminSuperUserID",
                table: "Admins",
                column: "AdminSuperUserID");

            migrationBuilder.CreateIndex(
                name: "IX_AdminSuperUsers_AdminID",
                table: "AdminSuperUsers",
                column: "AdminID");

            migrationBuilder.CreateIndex(
                name: "IX_AdminSuperUsers_SuperUserID",
                table: "AdminSuperUsers",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "AdminSuperUsers");

            migrationBuilder.DropIndex(
                name: "IX_SuperUsers_AdminSuperUserID",
                table: "SuperUsers");

            migrationBuilder.DropIndex(
                name: "IX_Admins_AdminSuperUserID",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "AdminSuperUserID",
                table: "SuperUsers");

            migrationBuilder.DropColumn(
                name: "AdminSuperUserID",
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
