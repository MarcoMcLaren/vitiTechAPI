using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class CityAndRegion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RegionID",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_RegionID",
                table: "Cities",
                column: "RegionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Regions_RegionID",
                table: "Cities",
                column: "RegionID",
                principalTable: "Regions",
                principalColumn: "RegionID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Regions_RegionID",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Cities_RegionID",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "RegionID",
                table: "Cities");
        }
    }
}
