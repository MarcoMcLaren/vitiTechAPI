using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ksdnjdns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WriteOffItemID",
                table: "WriteOffReasons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WriteOffReasonID",
                table: "WriteOffItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WriteOffReasons_WriteOffItemID",
                table: "WriteOffReasons",
                column: "WriteOffItemID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_WriteOffReasons_WriteOffItems_WriteOffItemID",
                table: "WriteOffReasons",
                column: "WriteOffItemID",
                principalTable: "WriteOffItems",
                principalColumn: "WriteOffItemID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WriteOffReasons_WriteOffItems_WriteOffItemID",
                table: "WriteOffReasons");

            migrationBuilder.DropIndex(
                name: "IX_WriteOffReasons_WriteOffItemID",
                table: "WriteOffReasons");

            migrationBuilder.DropColumn(
                name: "WriteOffItemID",
                table: "WriteOffReasons");

            migrationBuilder.DropColumn(
                name: "WriteOffReasonID",
                table: "WriteOffItems");
        }
    }
}
