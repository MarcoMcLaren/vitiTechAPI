using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class dnjsdj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_Users_AdminSuperUserID",
                table: "Admins");

            migrationBuilder.DropTable(
                name: "AdminSuperUsers");

            migrationBuilder.DropIndex(
                name: "IX_Admins_AdminSuperUserID",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "AdminSuperUserID",
                table: "Admins");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdminSuperUserID",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AdminSuperUsers",
                columns: table => new
                {
                    AdminSuperUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminID1 = table.Column<int>(type: "int", nullable: true),
                    SuperUserID = table.Column<int>(type: "int", nullable: false),
                    AdminID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminSuperUsers", x => x.AdminSuperUserID);
                    table.ForeignKey(
                        name: "FK_AdminSuperUsers_Admins_AdminID1",
                        column: x => x.AdminID1,
                        principalTable: "Admins",
                        principalColumn: "AdminID");
                    table.ForeignKey(
                        name: "FK_AdminSuperUsers_SuperUsers_SuperUserID",
                        column: x => x.SuperUserID,
                        principalTable: "SuperUsers",
                        principalColumn: "SuperUserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_AdminSuperUserID",
                table: "Admins",
                column: "AdminSuperUserID");

            migrationBuilder.CreateIndex(
                name: "IX_AdminSuperUsers_AdminID1",
                table: "AdminSuperUsers",
                column: "AdminID1");

            migrationBuilder.CreateIndex(
                name: "IX_AdminSuperUsers_SuperUserID",
                table: "AdminSuperUsers",
                column: "SuperUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_Users_AdminSuperUserID",
                table: "Admins",
                column: "AdminSuperUserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
