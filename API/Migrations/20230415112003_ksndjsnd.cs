using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ksndjsnd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RefundTypeID",
                table: "RefundReasons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RefundReasons_RefundTypeID",
                table: "RefundReasons",
                column: "RefundTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_RefundReasons_RefundTypes_RefundTypeID",
                table: "RefundReasons",
                column: "RefundTypeID",
                principalTable: "RefundTypes",
                principalColumn: "RefundTypeID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefundReasons_RefundTypes_RefundTypeID",
                table: "RefundReasons");

            migrationBuilder.DropIndex(
                name: "IX_RefundReasons_RefundTypeID",
                table: "RefundReasons");

            migrationBuilder.DropColumn(
                name: "RefundTypeID",
                table: "RefundReasons");
        }
    }
}
