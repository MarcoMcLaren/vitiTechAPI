using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class jsndd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RefundReasonID",
                table: "Refunds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Refunds_RefundReasonID",
                table: "Refunds",
                column: "RefundReasonID");

            migrationBuilder.AddForeignKey(
                name: "FK_Refunds_RefundReasons_RefundReasonID",
                table: "Refunds",
                column: "RefundReasonID",
                principalTable: "RefundReasons",
                principalColumn: "RefundReasonID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Refunds_RefundReasons_RefundReasonID",
                table: "Refunds");

            migrationBuilder.DropIndex(
                name: "IX_Refunds_RefundReasonID",
                table: "Refunds");

            migrationBuilder.DropColumn(
                name: "RefundReasonID",
                table: "Refunds");
        }
    }
}
