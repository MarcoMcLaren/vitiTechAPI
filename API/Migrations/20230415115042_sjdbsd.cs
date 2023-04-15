using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class sjdbsd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WriteOffID",
                table: "WriteOffItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WriteOffItems_WriteOffID",
                table: "WriteOffItems",
                column: "WriteOffID");

            migrationBuilder.AddForeignKey(
                name: "FK_WriteOffItems_WriteOffs_WriteOffID",
                table: "WriteOffItems",
                column: "WriteOffID",
                principalTable: "WriteOffs",
                principalColumn: "WriteOffID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WriteOffItems_WriteOffs_WriteOffID",
                table: "WriteOffItems");

            migrationBuilder.DropIndex(
                name: "IX_WriteOffItems_WriteOffID",
                table: "WriteOffItems");

            migrationBuilder.DropColumn(
                name: "WriteOffID",
                table: "WriteOffItems");
        }
    }
}
