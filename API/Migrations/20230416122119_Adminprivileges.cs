using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class Adminprivileges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdminPrivilegesID",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AdminPrivileges",
                columns: table => new
                {
                    AdminPrivilegesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Privilege_Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminPrivileges", x => x.AdminPrivilegesID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_AdminPrivilegesID",
                table: "Admins",
                column: "AdminPrivilegesID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_AdminPrivileges_AdminPrivilegesID",
                table: "Admins",
                column: "AdminPrivilegesID",
                principalTable: "AdminPrivileges",
                principalColumn: "AdminPrivilegesID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_AdminPrivileges_AdminPrivilegesID",
                table: "Admins");

            migrationBuilder.DropTable(
                name: "AdminPrivileges");

            migrationBuilder.DropIndex(
                name: "IX_Admins_AdminPrivilegesID",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "AdminPrivilegesID",
                table: "Admins");
        }
    }
}
