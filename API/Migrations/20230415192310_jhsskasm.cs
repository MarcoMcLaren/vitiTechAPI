using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class jhsskasm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "WriteOffs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WriteOffs_EmployeeID",
                table: "WriteOffs",
                column: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_WriteOffs_Employees_EmployeeID",
                table: "WriteOffs",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WriteOffs_Employees_EmployeeID",
                table: "WriteOffs");

            migrationBuilder.DropIndex(
                name: "IX_WriteOffs_EmployeeID",
                table: "WriteOffs");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "WriteOffs");
        }
    }
}
