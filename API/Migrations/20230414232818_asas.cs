using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class asas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventorie_Wine_WineID",
                table: "Inventorie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventorie",
                table: "Inventorie");

            migrationBuilder.DropIndex(
                name: "IX_Inventorie_WineID",
                table: "Inventorie");

            migrationBuilder.DropColumn(
                name: "WineID",
                table: "Inventorie");

            migrationBuilder.RenameTable(
                name: "Inventorie",
                newName: "Inventory");

            migrationBuilder.AddColumn<int>(
                name: "InventoryID",
                table: "StockTakeItem",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventory",
                table: "Inventory",
                column: "InventoryID");

            migrationBuilder.CreateIndex(
                name: "IX_StockTakeItem_InventoryID",
                table: "StockTakeItem",
                column: "InventoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_StockTakeItem_Inventory_InventoryID",
                table: "StockTakeItem",
                column: "InventoryID",
                principalTable: "Inventory",
                principalColumn: "InventoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockTakeItem_Inventory_InventoryID",
                table: "StockTakeItem");

            migrationBuilder.DropIndex(
                name: "IX_StockTakeItem_InventoryID",
                table: "StockTakeItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventory",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "InventoryID",
                table: "StockTakeItem");

            migrationBuilder.RenameTable(
                name: "Inventory",
                newName: "Inventorie");

            migrationBuilder.AddColumn<int>(
                name: "WineID",
                table: "Inventorie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventorie",
                table: "Inventorie",
                column: "InventoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventorie_WineID",
                table: "Inventorie",
                column: "WineID");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventorie_Wine_WineID",
                table: "Inventorie",
                column: "WineID",
                principalTable: "Wine",
                principalColumn: "WineID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
