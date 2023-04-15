using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class jsndjsd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockTakeItem_Inventory_InventoryID",
                table: "StockTakeItem");

            migrationBuilder.DropForeignKey(
                name: "FK_StockTakeItem_StockTake_StockTakeID",
                table: "StockTakeItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WriteOffReason",
                table: "WriteOffReason");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WriteOffItem",
                table: "WriteOffItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WriteOff",
                table: "WriteOff");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WishlistItem",
                table: "WishlistItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Wishlist",
                table: "Wishlist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WineType",
                table: "WineType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WinePrice",
                table: "WinePrice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WineDiscount",
                table: "WineDiscount");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Wine",
                table: "Wine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VAT",
                table: "VAT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Varietal",
                table: "Varietal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ticket",
                table: "Ticket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupplierPayment",
                table: "SupplierPayment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupplierOrder",
                table: "SupplierOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockTakeItem",
                table: "StockTakeItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockTake",
                table: "StockTake");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShippingDetail",
                table: "ShippingDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Region",
                table: "Region");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RefundType",
                table: "RefundType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RefundResponse",
                table: "RefundResponse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RefundReason",
                table: "RefundReason");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Refund",
                table: "Refund");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderPayment",
                table: "OrderPayment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItem",
                table: "OrderItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventory",
                table: "Inventory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FAQ",
                table: "FAQ");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventType",
                table: "EventType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventPrice",
                table: "EventPrice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventLocation",
                table: "EventLocation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Event",
                table: "Event");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EarlyBird",
                table: "EarlyBird");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countrie",
                table: "Countrie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Citie",
                table: "Citie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookingPayment",
                table: "BookingPayment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Booking",
                table: "Booking");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blacklist",
                table: "Blacklist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admin",
                table: "Admin");

            migrationBuilder.RenameTable(
                name: "WriteOffReason",
                newName: "WriteOffReasons");

            migrationBuilder.RenameTable(
                name: "WriteOffItem",
                newName: "WriteOffItems");

            migrationBuilder.RenameTable(
                name: "WriteOff",
                newName: "WriteOffs");

            migrationBuilder.RenameTable(
                name: "WishlistItem",
                newName: "WishlistItems");

            migrationBuilder.RenameTable(
                name: "Wishlist",
                newName: "Wishlists");

            migrationBuilder.RenameTable(
                name: "WineType",
                newName: "WineTypes");

            migrationBuilder.RenameTable(
                name: "WinePrice",
                newName: "WinePrices");

            migrationBuilder.RenameTable(
                name: "WineDiscount",
                newName: "WineDiscounts");

            migrationBuilder.RenameTable(
                name: "Wine",
                newName: "Wines");

            migrationBuilder.RenameTable(
                name: "VAT",
                newName: "VATs");

            migrationBuilder.RenameTable(
                name: "Varietal",
                newName: "Varietals");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Ticket",
                newName: "Tickets");

            migrationBuilder.RenameTable(
                name: "SupplierPayment",
                newName: "SupplierPayments");

            migrationBuilder.RenameTable(
                name: "SupplierOrder",
                newName: "SupplierOrders");

            migrationBuilder.RenameTable(
                name: "Supplier",
                newName: "Suppliers");

            migrationBuilder.RenameTable(
                name: "StockTakeItem",
                newName: "StockTakeItems");

            migrationBuilder.RenameTable(
                name: "StockTake",
                newName: "StockTakes");

            migrationBuilder.RenameTable(
                name: "ShippingDetail",
                newName: "ShippingDetails");

            migrationBuilder.RenameTable(
                name: "Region",
                newName: "Regions");

            migrationBuilder.RenameTable(
                name: "RefundType",
                newName: "RefundTypes");

            migrationBuilder.RenameTable(
                name: "RefundResponse",
                newName: "RefundResponses");

            migrationBuilder.RenameTable(
                name: "RefundReason",
                newName: "RefundReasons");

            migrationBuilder.RenameTable(
                name: "Refund",
                newName: "Refunds");

            migrationBuilder.RenameTable(
                name: "OrderPayment",
                newName: "OrderPayments");

            migrationBuilder.RenameTable(
                name: "OrderItem",
                newName: "OrderItems");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "Inventory",
                newName: "Inventories");

            migrationBuilder.RenameTable(
                name: "FAQ",
                newName: "FAQs");

            migrationBuilder.RenameTable(
                name: "EventType",
                newName: "EventTypes");

            migrationBuilder.RenameTable(
                name: "EventPrice",
                newName: "EventPrices");

            migrationBuilder.RenameTable(
                name: "EventLocation",
                newName: "EventLocations");

            migrationBuilder.RenameTable(
                name: "Event",
                newName: "Events");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "EarlyBird",
                newName: "EarlyBirds");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameTable(
                name: "Countrie",
                newName: "Countries");

            migrationBuilder.RenameTable(
                name: "Citie",
                newName: "Cities");

            migrationBuilder.RenameTable(
                name: "BookingPayment",
                newName: "BookingPayments");

            migrationBuilder.RenameTable(
                name: "Booking",
                newName: "Bookings");

            migrationBuilder.RenameTable(
                name: "Blacklist",
                newName: "Blacklists");

            migrationBuilder.RenameTable(
                name: "Admin",
                newName: "Admins");

            migrationBuilder.RenameIndex(
                name: "IX_StockTakeItem_StockTakeID",
                table: "StockTakeItems",
                newName: "IX_StockTakeItems_StockTakeID");

            migrationBuilder.RenameIndex(
                name: "IX_StockTakeItem_InventoryID",
                table: "StockTakeItems",
                newName: "IX_StockTakeItems_InventoryID");

            migrationBuilder.AddColumn<int>(
                name: "WineID",
                table: "Inventories",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WriteOffReasons",
                table: "WriteOffReasons",
                column: "WriteOff_ReasonID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WriteOffItems",
                table: "WriteOffItems",
                column: "WriteOffItemID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WriteOffs",
                table: "WriteOffs",
                column: "WriteOffID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WishlistItems",
                table: "WishlistItems",
                column: "WishlistItemID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wishlists",
                table: "Wishlists",
                column: "WishlistID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WineTypes",
                table: "WineTypes",
                column: "WineTypeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WinePrices",
                table: "WinePrices",
                column: "WinePriceID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WineDiscounts",
                table: "WineDiscounts",
                column: "WineDiscountID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wines",
                table: "Wines",
                column: "WineID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VATs",
                table: "VATs",
                column: "VATID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Varietals",
                table: "Varietals",
                column: "VarietalID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets",
                column: "TicketID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupplierPayments",
                table: "SupplierPayments",
                column: "SupplierPaymentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupplierOrders",
                table: "SupplierOrders",
                column: "SupplierOrderID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers",
                column: "SupplierID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockTakeItems",
                table: "StockTakeItems",
                column: "StockTake_ItemID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockTakes",
                table: "StockTakes",
                column: "StockTakeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShippingDetails",
                table: "ShippingDetails",
                column: "ShippingID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Regions",
                table: "Regions",
                column: "RegionID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RefundTypes",
                table: "RefundTypes",
                column: "RefundTypeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RefundResponses",
                table: "RefundResponses",
                column: "RefundResponseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RefundReasons",
                table: "RefundReasons",
                column: "RefundReasonID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Refunds",
                table: "Refunds",
                column: "RefundID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderPayments",
                table: "OrderPayments",
                column: "PaymentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems",
                column: "OrderItemID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "OrderID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories",
                column: "InventoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FAQs",
                table: "FAQs",
                column: "FAQID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventTypes",
                table: "EventTypes",
                column: "EventTypeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventPrices",
                table: "EventPrices",
                column: "EventPriceID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventLocations",
                table: "EventLocations",
                column: "EventLocationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events",
                table: "Events",
                column: "EventID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmployeeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EarlyBirds",
                table: "EarlyBirds",
                column: "EarlyBirdID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "CustomerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "CountryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "CityID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookingPayments",
                table: "BookingPayments",
                column: "PaymentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings",
                column: "BookingID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blacklists",
                table: "Blacklists",
                column: "UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admins",
                table: "Admins",
                column: "AdminID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_WineID",
                table: "Inventories",
                column: "WineID");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Wines_WineID",
                table: "Inventories",
                column: "WineID",
                principalTable: "Wines",
                principalColumn: "WineID");

            migrationBuilder.AddForeignKey(
                name: "FK_StockTakeItems_Inventories_InventoryID",
                table: "StockTakeItems",
                column: "InventoryID",
                principalTable: "Inventories",
                principalColumn: "InventoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_StockTakeItems_StockTakes_StockTakeID",
                table: "StockTakeItems",
                column: "StockTakeID",
                principalTable: "StockTakes",
                principalColumn: "StockTakeID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Wines_WineID",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_StockTakeItems_Inventories_InventoryID",
                table: "StockTakeItems");

            migrationBuilder.DropForeignKey(
                name: "FK_StockTakeItems_StockTakes_StockTakeID",
                table: "StockTakeItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WriteOffs",
                table: "WriteOffs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WriteOffReasons",
                table: "WriteOffReasons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WriteOffItems",
                table: "WriteOffItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Wishlists",
                table: "Wishlists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WishlistItems",
                table: "WishlistItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WineTypes",
                table: "WineTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Wines",
                table: "Wines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WinePrices",
                table: "WinePrices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WineDiscounts",
                table: "WineDiscounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VATs",
                table: "VATs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Varietals",
                table: "Varietals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Suppliers",
                table: "Suppliers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupplierPayments",
                table: "SupplierPayments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SupplierOrders",
                table: "SupplierOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockTakes",
                table: "StockTakes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockTakeItems",
                table: "StockTakeItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShippingDetails",
                table: "ShippingDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Regions",
                table: "Regions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RefundTypes",
                table: "RefundTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Refunds",
                table: "Refunds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RefundResponses",
                table: "RefundResponses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RefundReasons",
                table: "RefundReasons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderPayments",
                table: "OrderPayments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_WineID",
                table: "Inventories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FAQs",
                table: "FAQs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventTypes",
                table: "EventTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                table: "Events");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventPrices",
                table: "EventPrices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventLocations",
                table: "EventLocations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EarlyBirds",
                table: "EarlyBirds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookingPayments",
                table: "BookingPayments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blacklists",
                table: "Blacklists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Admins",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "WineID",
                table: "Inventories");

            migrationBuilder.RenameTable(
                name: "WriteOffs",
                newName: "WriteOff");

            migrationBuilder.RenameTable(
                name: "WriteOffReasons",
                newName: "WriteOffReason");

            migrationBuilder.RenameTable(
                name: "WriteOffItems",
                newName: "WriteOffItem");

            migrationBuilder.RenameTable(
                name: "Wishlists",
                newName: "Wishlist");

            migrationBuilder.RenameTable(
                name: "WishlistItems",
                newName: "WishlistItem");

            migrationBuilder.RenameTable(
                name: "WineTypes",
                newName: "WineType");

            migrationBuilder.RenameTable(
                name: "Wines",
                newName: "Wine");

            migrationBuilder.RenameTable(
                name: "WinePrices",
                newName: "WinePrice");

            migrationBuilder.RenameTable(
                name: "WineDiscounts",
                newName: "WineDiscount");

            migrationBuilder.RenameTable(
                name: "VATs",
                newName: "VAT");

            migrationBuilder.RenameTable(
                name: "Varietals",
                newName: "Varietal");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Tickets",
                newName: "Ticket");

            migrationBuilder.RenameTable(
                name: "Suppliers",
                newName: "Supplier");

            migrationBuilder.RenameTable(
                name: "SupplierPayments",
                newName: "SupplierPayment");

            migrationBuilder.RenameTable(
                name: "SupplierOrders",
                newName: "SupplierOrder");

            migrationBuilder.RenameTable(
                name: "StockTakes",
                newName: "StockTake");

            migrationBuilder.RenameTable(
                name: "StockTakeItems",
                newName: "StockTakeItem");

            migrationBuilder.RenameTable(
                name: "ShippingDetails",
                newName: "ShippingDetail");

            migrationBuilder.RenameTable(
                name: "Regions",
                newName: "Region");

            migrationBuilder.RenameTable(
                name: "RefundTypes",
                newName: "RefundType");

            migrationBuilder.RenameTable(
                name: "Refunds",
                newName: "Refund");

            migrationBuilder.RenameTable(
                name: "RefundResponses",
                newName: "RefundResponse");

            migrationBuilder.RenameTable(
                name: "RefundReasons",
                newName: "RefundReason");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "OrderPayments",
                newName: "OrderPayment");

            migrationBuilder.RenameTable(
                name: "OrderItems",
                newName: "OrderItem");

            migrationBuilder.RenameTable(
                name: "Inventories",
                newName: "Inventory");

            migrationBuilder.RenameTable(
                name: "FAQs",
                newName: "FAQ");

            migrationBuilder.RenameTable(
                name: "EventTypes",
                newName: "EventType");

            migrationBuilder.RenameTable(
                name: "Events",
                newName: "Event");

            migrationBuilder.RenameTable(
                name: "EventPrices",
                newName: "EventPrice");

            migrationBuilder.RenameTable(
                name: "EventLocations",
                newName: "EventLocation");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameTable(
                name: "EarlyBirds",
                newName: "EarlyBird");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "Countrie");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "Citie");

            migrationBuilder.RenameTable(
                name: "Bookings",
                newName: "Booking");

            migrationBuilder.RenameTable(
                name: "BookingPayments",
                newName: "BookingPayment");

            migrationBuilder.RenameTable(
                name: "Blacklists",
                newName: "Blacklist");

            migrationBuilder.RenameTable(
                name: "Admins",
                newName: "Admin");

            migrationBuilder.RenameIndex(
                name: "IX_StockTakeItems_StockTakeID",
                table: "StockTakeItem",
                newName: "IX_StockTakeItem_StockTakeID");

            migrationBuilder.RenameIndex(
                name: "IX_StockTakeItems_InventoryID",
                table: "StockTakeItem",
                newName: "IX_StockTakeItem_InventoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WriteOff",
                table: "WriteOff",
                column: "WriteOffID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WriteOffReason",
                table: "WriteOffReason",
                column: "WriteOff_ReasonID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WriteOffItem",
                table: "WriteOffItem",
                column: "WriteOffItemID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wishlist",
                table: "Wishlist",
                column: "WishlistID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WishlistItem",
                table: "WishlistItem",
                column: "WishlistItemID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WineType",
                table: "WineType",
                column: "WineTypeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wine",
                table: "Wine",
                column: "WineID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WinePrice",
                table: "WinePrice",
                column: "WinePriceID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WineDiscount",
                table: "WineDiscount",
                column: "WineDiscountID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VAT",
                table: "VAT",
                column: "VATID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Varietal",
                table: "Varietal",
                column: "VarietalID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ticket",
                table: "Ticket",
                column: "TicketID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Supplier",
                table: "Supplier",
                column: "SupplierID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupplierPayment",
                table: "SupplierPayment",
                column: "SupplierPaymentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupplierOrder",
                table: "SupplierOrder",
                column: "SupplierOrderID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockTake",
                table: "StockTake",
                column: "StockTakeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockTakeItem",
                table: "StockTakeItem",
                column: "StockTake_ItemID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShippingDetail",
                table: "ShippingDetail",
                column: "ShippingID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Region",
                table: "Region",
                column: "RegionID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RefundType",
                table: "RefundType",
                column: "RefundTypeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Refund",
                table: "Refund",
                column: "RefundID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RefundResponse",
                table: "RefundResponse",
                column: "RefundResponseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RefundReason",
                table: "RefundReason",
                column: "RefundReasonID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "OrderID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderPayment",
                table: "OrderPayment",
                column: "PaymentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItem",
                table: "OrderItem",
                column: "OrderItemID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventory",
                table: "Inventory",
                column: "InventoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FAQ",
                table: "FAQ",
                column: "FAQID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventType",
                table: "EventType",
                column: "EventTypeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Event",
                table: "Event",
                column: "EventID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventPrice",
                table: "EventPrice",
                column: "EventPriceID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventLocation",
                table: "EventLocation",
                column: "EventLocationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "EmployeeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EarlyBird",
                table: "EarlyBird",
                column: "EarlyBirdID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "CustomerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countrie",
                table: "Countrie",
                column: "CountryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Citie",
                table: "Citie",
                column: "CityID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Booking",
                table: "Booking",
                column: "BookingID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookingPayment",
                table: "BookingPayment",
                column: "PaymentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blacklist",
                table: "Blacklist",
                column: "UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admin",
                table: "Admin",
                column: "AdminID");

            migrationBuilder.AddForeignKey(
                name: "FK_StockTakeItem_Inventory_InventoryID",
                table: "StockTakeItem",
                column: "InventoryID",
                principalTable: "Inventory",
                principalColumn: "InventoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_StockTakeItem_StockTake_StockTakeID",
                table: "StockTakeItem",
                column: "StockTakeID",
                principalTable: "StockTake",
                principalColumn: "StockTakeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
