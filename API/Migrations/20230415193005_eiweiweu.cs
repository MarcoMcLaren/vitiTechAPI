using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class eiweiweu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdminID",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AdminID",
                table: "Employees",
                column: "AdminID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Admins_AdminID",
                table: "Employees",
                column: "AdminID",
                principalTable: "Admins",
                principalColumn: "AdminID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Admins_AdminID",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_AdminID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "AdminID",
                table: "Employees");
        }
    }
}
