using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class uweuweyw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SuperUserID",
                table: "Admins",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SuperUser",
                columns: table => new
                {
                    SuperUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone_Number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ID_Number = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Hire_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdminID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperUser", x => x.SuperUserID);
                    table.ForeignKey(
                        name: "FK_SuperUser_Admins_AdminID",
                        column: x => x.AdminID,
                        principalTable: "Admins",
                        principalColumn: "AdminID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_SuperUserID",
                table: "Admins",
                column: "SuperUserID");

            migrationBuilder.CreateIndex(
                name: "IX_SuperUser_AdminID",
                table: "SuperUser",
                column: "AdminID");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_SuperUser_SuperUserID",
                table: "Admins",
                column: "SuperUserID",
                principalTable: "SuperUser",
                principalColumn: "SuperUserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admins_SuperUser_SuperUserID",
                table: "Admins");

            migrationBuilder.DropTable(
                name: "SuperUser");

            migrationBuilder.DropIndex(
                name: "IX_Admins_SuperUserID",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "SuperUserID",
                table: "Admins");
        }
    }
}
