﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blacklists",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reason = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blacklists", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    First_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Last_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Phone_Number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ID_Number = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Date_Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_of_last_update = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    DiscountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscountCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DiscountType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DiscountAmount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.DiscountID);
                });

            migrationBuilder.CreateTable(
                name: "EarlyBirds",
                columns: table => new
                {
                    EarlyBirdID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Percentage = table.Column<double>(type: "float", nullable: false),
                    Limit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EarlyBirds", x => x.EarlyBirdID);
                });

            migrationBuilder.CreateTable(
                name: "EventLocations",
                columns: table => new
                {
                    EventLocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street_Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Postal_Code = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Date_of_last_update = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventLocations", x => x.EventLocationID);
                });

            migrationBuilder.CreateTable(
                name: "EventPrices",
                columns: table => new
                {
                    EventPriceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventPrices", x => x.EventPriceID);
                });

            migrationBuilder.CreateTable(
                name: "EventTypes",
                columns: table => new
                {
                    EventTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EventDescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTypes", x => x.EventTypeID);
                });

            migrationBuilder.CreateTable(
                name: "FAQs",
                columns: table => new
                {
                    FAQID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQs", x => x.FAQID);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatus",
                columns: table => new
                {
                    OrderStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatus", x => x.OrderStatusID);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    ProvinceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_of_last_update = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.ProvinceID);
                });

            migrationBuilder.CreateTable(
                name: "RefundResponses",
                columns: table => new
                {
                    RefundResponseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResponseValue = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefundResponses", x => x.RefundResponseID);
                });

            migrationBuilder.CreateTable(
                name: "RefundTypes",
                columns: table => new
                {
                    RefundTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefundTypes", x => x.RefundTypeID);
                });

            migrationBuilder.CreateTable(
                name: "StockTakes",
                columns: table => new
                {
                    StockTakeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockTake_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StockTake_Notes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockTakes", x => x.StockTakeID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierID);
                });

            migrationBuilder.CreateTable(
                name: "SystemPrivileges",
                columns: table => new
                {
                    SystemPrivilegeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SystemPrivilegeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemPrivileges", x => x.SystemPrivilegeID);
                });

            migrationBuilder.CreateTable(
                name: "Varietals",
                columns: table => new
                {
                    VarietalID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Varietals", x => x.VarietalID);
                });

            migrationBuilder.CreateTable(
                name: "VATs",
                columns: table => new
                {
                    VATID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Percentage = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VATs", x => x.VATID);
                });

            migrationBuilder.CreateTable(
                name: "WineTypes",
                columns: table => new
                {
                    WineTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WineTypes", x => x.WineTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street_Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Postal_Code = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true),
                    Date_of_last_update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressID);
                    table.ForeignKey(
                        name: "FK_Addresses_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "EventReviews",
                columns: table => new
                {
                    EventReviewID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Review_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventReviews", x => x.EventReviewID);
                    table.ForeignKey(
                        name: "FK_EventReviews_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UserPassword = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustomerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    WishlistID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => x.WishlistID);
                    table.ForeignKey(
                        name: "FK_Wishlists_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tickets_Available = table.Column<int>(type: "int", nullable: false),
                    Tickets_Sold = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EarlyBird = table.Column<int>(type: "int", nullable: false),
                    Image_URL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EventPriceID = table.Column<int>(type: "int", nullable: false),
                    EventTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventID);
                    table.ForeignKey(
                        name: "FK_Events_EventPrices_EventPriceID",
                        column: x => x.EventPriceID,
                        principalTable: "EventPrices",
                        principalColumn: "EventPriceID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Events_EventTypes_EventTypeID",
                        column: x => x.EventTypeID,
                        principalTable: "EventTypes",
                        principalColumn: "EventTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShippingID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    OrderStatusID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_OrderStatus_OrderStatusID",
                        column: x => x.OrderStatusID,
                        principalTable: "OrderStatus",
                        principalColumn: "OrderStatusID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RefundReasons",
                columns: table => new
                {
                    RefundReasonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RefundTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefundReasons", x => x.RefundReasonID);
                    table.ForeignKey(
                        name: "FK_RefundReasons_RefundTypes_RefundTypeID",
                        column: x => x.RefundTypeID,
                        principalTable: "RefundTypes",
                        principalColumn: "RefundTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Last_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Phone_Number = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ID_Number = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: true),
                    Hire_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employees_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SuperUser",
                columns: table => new
                {
                    SuperUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Phone_Number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ID_Number = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Hire_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    AddressID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperUser", x => x.SuperUserID);
                    table.ForeignKey(
                        name: "FK_SuperUser_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SuperUser_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingID);
                    table.ForeignKey(
                        name: "FK_Bookings_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Bookings_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderPayments",
                columns: table => new
                {
                    PaymentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmountID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPayments", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_OrderPayments_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShippingDetails",
                columns: table => new
                {
                    ShippingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShippingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrackingNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OrderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingDetails", x => x.ShippingID);
                    table.ForeignKey(
                        name: "FK_ShippingDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wines",
                columns: table => new
                {
                    WineID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Vintage = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RestockLimit = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    WineTastingNote = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    WinePrice = table.Column<double>(type: "float", nullable: false),
                    WineTypeID = table.Column<int>(type: "int", nullable: false),
                    VarietalID = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wines", x => x.WineID);
                    table.ForeignKey(
                        name: "FK_Wines_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wines_Varietals_VarietalID",
                        column: x => x.VarietalID,
                        principalTable: "Varietals",
                        principalColumn: "VarietalID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wines_WineTypes_WineTypeID",
                        column: x => x.WineTypeID,
                        principalTable: "WineTypes",
                        principalColumn: "WineTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WriteOffs",
                columns: table => new
                {
                    WriteOffID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WriteOff_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WriteOffs", x => x.WriteOffID);
                    table.ForeignKey(
                        name: "FK_WriteOffs_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingPayments",
                columns: table => new
                {
                    PaymentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentAmount = table.Column<double>(type: "float", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingPayments", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_BookingPayments_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "BookingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketPrice = table.Column<double>(type: "float", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QRCode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    BookingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketID);
                    table.ForeignKey(
                        name: "FK_Tickets_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "BookingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    InventoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockLimit = table.Column<int>(type: "int", nullable: false),
                    QuantityOnHand = table.Column<int>(type: "int", nullable: false),
                    WineID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.InventoryID);
                    table.ForeignKey(
                        name: "FK_Inventories_Wines_WineID",
                        column: x => x.WineID,
                        principalTable: "Wines",
                        principalColumn: "WineID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    WineID = table.Column<int>(type: "int", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.OrderItemID);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Wines_WineID",
                        column: x => x.WineID,
                        principalTable: "Wines",
                        principalColumn: "WineID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierOrders",
                columns: table => new
                {
                    SupplierOrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity_Ordered = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WineID = table.Column<int>(type: "int", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    SupplierPaymentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierOrders", x => x.SupplierOrderID);
                    table.ForeignKey(
                        name: "FK_SupplierOrders_Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierOrders_Wines_WineID",
                        column: x => x.WineID,
                        principalTable: "Wines",
                        principalColumn: "WineID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WineDiscounts",
                columns: table => new
                {
                    WineDiscountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WineID = table.Column<int>(type: "int", nullable: false),
                    DiscountID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WineDiscounts", x => x.WineDiscountID);
                    table.ForeignKey(
                        name: "FK_WineDiscounts_Discounts_DiscountID",
                        column: x => x.DiscountID,
                        principalTable: "Discounts",
                        principalColumn: "DiscountID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WineDiscounts_Wines_WineID",
                        column: x => x.WineID,
                        principalTable: "Wines",
                        principalColumn: "WineID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WishlistItems",
                columns: table => new
                {
                    WishlistItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WineID = table.Column<int>(type: "int", nullable: false),
                    WishlistID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishlistItems", x => x.WishlistItemID);
                    table.ForeignKey(
                        name: "FK_WishlistItems_Wines_WineID",
                        column: x => x.WineID,
                        principalTable: "Wines",
                        principalColumn: "WineID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WishlistItems_Wishlists_WishlistID",
                        column: x => x.WishlistID,
                        principalTable: "Wishlists",
                        principalColumn: "WishlistID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockTakeItems",
                columns: table => new
                {
                    StockTake_ItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockTakeID = table.Column<int>(type: "int", nullable: false),
                    QuantityCounted = table.Column<int>(type: "int", nullable: false),
                    InventoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockTakeItems", x => x.StockTake_ItemID);
                    table.ForeignKey(
                        name: "FK_StockTakeItems_Inventories_InventoryID",
                        column: x => x.InventoryID,
                        principalTable: "Inventories",
                        principalColumn: "InventoryID");
                    table.ForeignKey(
                        name: "FK_StockTakeItems_StockTakes_StockTakeID",
                        column: x => x.StockTakeID,
                        principalTable: "StockTakes",
                        principalColumn: "StockTakeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Refunds",
                columns: table => new
                {
                    RefundID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuantityRefunded = table.Column<int>(type: "int", nullable: false),
                    DateIssued = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResolvedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrderItemID = table.Column<int>(type: "int", nullable: false),
                    RefundResponseID = table.Column<int>(type: "int", nullable: false),
                    RefundReasonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refunds", x => x.RefundID);
                    table.ForeignKey(
                        name: "FK_Refunds_OrderItems_OrderItemID",
                        column: x => x.OrderItemID,
                        principalTable: "OrderItems",
                        principalColumn: "OrderItemID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Refunds_RefundReasons_RefundReasonID",
                        column: x => x.RefundReasonID,
                        principalTable: "RefundReasons",
                        principalColumn: "RefundReasonID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Refunds_RefundResponses_RefundResponseID",
                        column: x => x.RefundResponseID,
                        principalTable: "RefundResponses",
                        principalColumn: "RefundResponseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplierPayments",
                columns: table => new
                {
                    SupplierPaymentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmountPaid = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SupplierOrderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierPayments", x => x.SupplierPaymentID);
                    table.ForeignKey(
                        name: "FK_SupplierPayments_SupplierOrders_SupplierOrderID",
                        column: x => x.SupplierOrderID,
                        principalTable: "SupplierOrders",
                        principalColumn: "SupplierOrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WriteOffItems",
                columns: table => new
                {
                    WriteOffItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WriteOff_Quantity = table.Column<int>(type: "int", nullable: false),
                    WineID = table.Column<int>(type: "int", nullable: false),
                    WriteOffReasonID = table.Column<int>(type: "int", nullable: false),
                    WriteOffID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WriteOffItems", x => x.WriteOffItemID);
                    table.ForeignKey(
                        name: "FK_WriteOffItems_Wines_WineID",
                        column: x => x.WineID,
                        principalTable: "Wines",
                        principalColumn: "WineID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WriteOffItems_WriteOffs_WriteOffID",
                        column: x => x.WriteOffID,
                        principalTable: "WriteOffs",
                        principalColumn: "WriteOffID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WriteOffReasons",
                columns: table => new
                {
                    WriteOff_ReasonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Date_of_last_update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WriteOffItemID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WriteOffReasons", x => x.WriteOff_ReasonID);
                    table.ForeignKey(
                        name: "FK_WriteOffReasons_WriteOffItems_WriteOffItemID",
                        column: x => x.WriteOffItemID,
                        principalTable: "WriteOffItems",
                        principalColumn: "WriteOffItemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CustomerID",
                table: "Addresses",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_BookingPayments_BookingId",
                table: "BookingPayments",
                column: "BookingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomerId",
                table: "Bookings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_EventId",
                table: "Bookings",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserID",
                table: "Employees",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EventReviews_CustomerID",
                table: "EventReviews",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventPriceID",
                table: "Events",
                column: "EventPriceID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventTypeID",
                table: "Events",
                column: "EventTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_WineID",
                table: "Inventories",
                column: "WineID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderID",
                table: "OrderItems",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_WineID",
                table: "OrderItems",
                column: "WineID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderPayments_OrderID",
                table: "OrderPayments",
                column: "OrderID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderStatusID",
                table: "Orders",
                column: "OrderStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_RefundReasons_RefundTypeID",
                table: "RefundReasons",
                column: "RefundTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Refunds_OrderItemID",
                table: "Refunds",
                column: "OrderItemID");

            migrationBuilder.CreateIndex(
                name: "IX_Refunds_RefundReasonID",
                table: "Refunds",
                column: "RefundReasonID");

            migrationBuilder.CreateIndex(
                name: "IX_Refunds_RefundResponseID",
                table: "Refunds",
                column: "RefundResponseID");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingDetails_OrderID",
                table: "ShippingDetails",
                column: "OrderID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StockTakeItems_InventoryID",
                table: "StockTakeItems",
                column: "InventoryID");

            migrationBuilder.CreateIndex(
                name: "IX_StockTakeItems_StockTakeID",
                table: "StockTakeItems",
                column: "StockTakeID");

            migrationBuilder.CreateIndex(
                name: "IX_SuperUser_AddressID",
                table: "SuperUser",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_SuperUser_UserID",
                table: "SuperUser",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierOrders_SupplierID",
                table: "SupplierOrders",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierOrders_WineID",
                table: "SupplierOrders",
                column: "WineID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierPayments_SupplierOrderID",
                table: "SupplierPayments",
                column: "SupplierOrderID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_BookingId",
                table: "Tickets",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CustomerID",
                table: "Users",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_WineDiscounts_DiscountID",
                table: "WineDiscounts",
                column: "DiscountID");

            migrationBuilder.CreateIndex(
                name: "IX_WineDiscounts_WineID",
                table: "WineDiscounts",
                column: "WineID");

            migrationBuilder.CreateIndex(
                name: "IX_Wines_EmployeeID",
                table: "Wines",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Wines_VarietalID",
                table: "Wines",
                column: "VarietalID");

            migrationBuilder.CreateIndex(
                name: "IX_Wines_WineTypeID",
                table: "Wines",
                column: "WineTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItems_WineID",
                table: "WishlistItems",
                column: "WineID");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItems_WishlistID",
                table: "WishlistItems",
                column: "WishlistID");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_CustomerID",
                table: "Wishlists",
                column: "CustomerID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WriteOffItems_WineID",
                table: "WriteOffItems",
                column: "WineID");

            migrationBuilder.CreateIndex(
                name: "IX_WriteOffItems_WriteOffID",
                table: "WriteOffItems",
                column: "WriteOffID");

            migrationBuilder.CreateIndex(
                name: "IX_WriteOffItems_WriteOffReasonID",
                table: "WriteOffItems",
                column: "WriteOffReasonID");

            migrationBuilder.CreateIndex(
                name: "IX_WriteOffReasons_WriteOffItemID",
                table: "WriteOffReasons",
                column: "WriteOffItemID");

            migrationBuilder.CreateIndex(
                name: "IX_WriteOffs_EmployeeID",
                table: "WriteOffs",
                column: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_WriteOffItems_WriteOffReasons_WriteOffReasonID",
                table: "WriteOffItems",
                column: "WriteOffReasonID",
                principalTable: "WriteOffReasons",
                principalColumn: "WriteOff_ReasonID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Customers_CustomerID",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Users_UserID",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_WriteOffItems_Wines_WineID",
                table: "WriteOffItems");

            migrationBuilder.DropForeignKey(
                name: "FK_WriteOffs_Employees_EmployeeID",
                table: "WriteOffs");

            migrationBuilder.DropForeignKey(
                name: "FK_WriteOffItems_WriteOffReasons_WriteOffReasonID",
                table: "WriteOffItems");

            migrationBuilder.DropTable(
                name: "Blacklists");

            migrationBuilder.DropTable(
                name: "BookingPayments");

            migrationBuilder.DropTable(
                name: "EarlyBirds");

            migrationBuilder.DropTable(
                name: "EventLocations");

            migrationBuilder.DropTable(
                name: "EventReviews");

            migrationBuilder.DropTable(
                name: "FAQs");

            migrationBuilder.DropTable(
                name: "OrderPayments");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "Refunds");

            migrationBuilder.DropTable(
                name: "ShippingDetails");

            migrationBuilder.DropTable(
                name: "StockTakeItems");

            migrationBuilder.DropTable(
                name: "SuperUser");

            migrationBuilder.DropTable(
                name: "SupplierPayments");

            migrationBuilder.DropTable(
                name: "SystemPrivileges");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "VATs");

            migrationBuilder.DropTable(
                name: "WineDiscounts");

            migrationBuilder.DropTable(
                name: "WishlistItems");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "RefundReasons");

            migrationBuilder.DropTable(
                name: "RefundResponses");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "StockTakes");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "SupplierOrders");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "Wishlists");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "RefundTypes");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "OrderStatus");

            migrationBuilder.DropTable(
                name: "EventPrices");

            migrationBuilder.DropTable(
                name: "EventTypes");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Wines");

            migrationBuilder.DropTable(
                name: "Varietals");

            migrationBuilder.DropTable(
                name: "WineTypes");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "WriteOffReasons");

            migrationBuilder.DropTable(
                name: "WriteOffItems");

            migrationBuilder.DropTable(
                name: "WriteOffs");
        }
    }
}
