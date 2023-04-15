using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ksdjndj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WishlistID",
                table: "WishlistItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItems_WishlistID",
                table: "WishlistItems",
                column: "WishlistID");

            migrationBuilder.AddForeignKey(
                name: "FK_WishlistItems_Wishlists_WishlistID",
                table: "WishlistItems",
                column: "WishlistID",
                principalTable: "Wishlists",
                principalColumn: "WishlistID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItems_Wishlists_WishlistID",
                table: "WishlistItems");

            migrationBuilder.DropIndex(
                name: "IX_WishlistItems_WishlistID",
                table: "WishlistItems");

            migrationBuilder.DropColumn(
                name: "WishlistID",
                table: "WishlistItems");
        }
    }
}
