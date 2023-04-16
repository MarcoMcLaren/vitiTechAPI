using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class SuperUserAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressID",
                table: "SuperUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SuperUser_AddressID",
                table: "SuperUser",
                column: "AddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_SuperUser_Addresses_AddressID",
                table: "SuperUser",
                column: "AddressID",
                principalTable: "Addresses",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SuperUser_Addresses_AddressID",
                table: "SuperUser");

            migrationBuilder.DropIndex(
                name: "IX_SuperUser_AddressID",
                table: "SuperUser");

            migrationBuilder.DropColumn(
                name: "AddressID",
                table: "SuperUser");
        }
    }
}
