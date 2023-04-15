using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class jbhsdbs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WineID",
                table: "WishlistItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItems_WineID",
                table: "WishlistItems",
                column: "WineID");

            migrationBuilder.AddForeignKey(
                name: "FK_WishlistItems_Wines_WineID",
                table: "WishlistItems",
                column: "WineID",
                principalTable: "Wines",
                principalColumn: "WineID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItems_Wines_WineID",
                table: "WishlistItems");

            migrationBuilder.DropIndex(
                name: "IX_WishlistItems_WineID",
                table: "WishlistItems");

            migrationBuilder.DropColumn(
                name: "WineID",
                table: "WishlistItems");
        }
    }
}
