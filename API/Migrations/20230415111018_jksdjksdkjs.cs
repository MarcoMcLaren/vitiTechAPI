using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class jksdjksdkjs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RefundResponseID",
                table: "Refunds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Refunds_RefundResponseID",
                table: "Refunds",
                column: "RefundResponseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Refunds_RefundResponses_RefundResponseID",
                table: "Refunds",
                column: "RefundResponseID",
                principalTable: "RefundResponses",
                principalColumn: "RefundResponseID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Refunds_RefundResponses_RefundResponseID",
                table: "Refunds");

            migrationBuilder.DropIndex(
                name: "IX_Refunds_RefundResponseID",
                table: "Refunds");

            migrationBuilder.DropColumn(
                name: "RefundResponseID",
                table: "Refunds");
        }
    }
}
