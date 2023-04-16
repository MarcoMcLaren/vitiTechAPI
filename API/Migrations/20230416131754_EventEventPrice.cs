using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class EventEventPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EventPriceID",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventPriceID",
                table: "Events",
                column: "EventPriceID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_EventPrices_EventPriceID",
                table: "Events",
                column: "EventPriceID",
                principalTable: "EventPrices",
                principalColumn: "EventPriceID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_EventPrices_EventPriceID",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_EventPriceID",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "EventPriceID",
                table: "Events");
        }
    }
}
