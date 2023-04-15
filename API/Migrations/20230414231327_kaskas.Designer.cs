﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230414231327_kaskas")]
    partial class kaskas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API.Model.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminID"));

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("First_Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Hire_Date")
                        .HasColumnType("datetime2");

                    b.Property<long>("ID_Number")
                        .HasMaxLength(13)
                        .HasColumnType("bigint");

                    b.Property<string>("Last_Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone_Number")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AdminID");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("API.Model.Blacklist", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Reason")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("UserID");

                    b.ToTable("Blacklist");
                });

            modelBuilder.Entity("API.Model.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingID"));

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BookingID");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("API.Model.BookingPayment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentID"));

                    b.Property<double>("PaymentAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PaymentID");

                    b.ToTable("BookingPayment");
                });

            modelBuilder.Entity("API.Model.City", b =>
                {
                    b.Property<int>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityID"));

                    b.Property<DateTime>("Date_of_last_update")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("CityID");

                    b.ToTable("Citie");
                });

            modelBuilder.Entity("API.Model.Country", b =>
                {
                    b.Property<int>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryID"));

                    b.Property<DateTime>("Date_of_last_update")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("CountryID");

                    b.ToTable("Countrie");
                });

            modelBuilder.Entity("API.Model.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<DateTime>("Date_Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_of_last_update")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("First_Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("ID_Number")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Last_Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone_Number")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("API.Model.Discount", b =>
                {
                    b.Property<int>("DiscountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiscountID"));

                    b.Property<double>("Discount_Amount")
                        .HasColumnType("float");

                    b.Property<string>("Discount_Code")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Discount_Type")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DiscountID");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("API.Model.EarlyBird", b =>
                {
                    b.Property<int>("EarlyBirdID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EarlyBirdID"));

                    b.Property<int>("Limit")
                        .HasColumnType("int");

                    b.Property<double>("Percentage")
                        .HasColumnType("float");

                    b.HasKey("EarlyBirdID");

                    b.ToTable("EarlyBird");
                });

            modelBuilder.Entity("API.Model.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"));

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("First_Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Hire_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("ID_Number")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Last_Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone_Number")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("API.Model.Event", b =>
                {
                    b.Property<int>("EventID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventID"));

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("EarlyBird")
                        .HasColumnType("int");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Tickets_Available")
                        .HasColumnType("int");

                    b.Property<int>("Tickets_Sold")
                        .HasColumnType("int");

                    b.Property<string>("image_URL")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("EventID");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("API.Model.EventLocation", b =>
                {
                    b.Property<int>("EventLocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventLocationID"));

                    b.Property<DateTime>("Date_of_last_update")
                        .HasColumnType("datetime2");

                    b.Property<string>("Postal_Code")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("Street_Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("EventLocationID");

                    b.ToTable("EventLocation");
                });

            modelBuilder.Entity("API.Model.EventPrice", b =>
                {
                    b.Property<int>("EventPriceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventPriceID"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.HasKey("EventPriceID");

                    b.ToTable("EventPrice");
                });

            modelBuilder.Entity("API.Model.EventReview", b =>
                {
                    b.Property<int>("EventReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventReviewID"));

                    b.Property<string>("Comment")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("Review_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("EventReviewID");

                    b.ToTable("EventReviews");
                });

            modelBuilder.Entity("API.Model.EventType", b =>
                {
                    b.Property<int>("EventTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventTypeID"));

                    b.Property<string>("EventDescription")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("EventTypeName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EventTypeID");

                    b.ToTable("EventType");
                });

            modelBuilder.Entity("API.Model.FAQ", b =>
                {
                    b.Property<int>("FAQID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FAQID"));

                    b.Property<string>("Answer")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Question")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("FAQID");

                    b.ToTable("FAQ");
                });

            modelBuilder.Entity("API.Model.Inventory", b =>
                {
                    b.Property<int>("InventoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InventoryID"));

                    b.Property<int>("Quantity_On_Hand")
                        .HasColumnType("int");

                    b.Property<int>("Stock_Limit")
                        .HasColumnType("int");

                    b.Property<int>("WineID")
                        .HasColumnType("int");

                    b.HasKey("InventoryID");

                    b.HasIndex("WineID");

                    b.ToTable("Inventorie");
                });

            modelBuilder.Entity("API.Model.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<DateTime>("Order_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("API.Model.OrderItem", b =>
                {
                    b.Property<int>("OrderItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemID"));

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderItemID");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("API.Model.OrderPayment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentID"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("AmountID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("PaymentID");

                    b.ToTable("OrderPayment");
                });

            modelBuilder.Entity("API.Model.OrderStatus", b =>
                {
                    b.Property<int>("OrderStatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderStatusID"));

                    b.Property<string>("OrderStatusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderStatusID");

                    b.ToTable("OrderStatus");
                });

            modelBuilder.Entity("API.Model.Refund", b =>
                {
                    b.Property<int>("RefundID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RefundID"));

                    b.Property<DateTime>("Date_Issued")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity_Refunded")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Resolved_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("RefundID");

                    b.ToTable("Refund");
                });

            modelBuilder.Entity("API.Model.RefundReason", b =>
                {
                    b.Property<int>("RefundReasonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RefundReasonID"));

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("RefundReasonID");

                    b.ToTable("RefundReason");
                });

            modelBuilder.Entity("API.Model.RefundResponse", b =>
                {
                    b.Property<int>("RefundResponseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RefundResponseID"));

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ResponseValue")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("RefundResponseID");

                    b.ToTable("RefundResponse");
                });

            modelBuilder.Entity("API.Model.RefundType", b =>
                {
                    b.Property<int>("RefundTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RefundTypeID"));

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("RefundTypeID");

                    b.ToTable("RefundType");
                });

            modelBuilder.Entity("API.Model.Region", b =>
                {
                    b.Property<int>("RegionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RegionID"));

                    b.Property<DateTime>("Date_of_last_update")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("RegionID");

                    b.ToTable("Region");
                });

            modelBuilder.Entity("API.Model.ShippingDetails", b =>
                {
                    b.Property<int>("ShippingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShippingID"));

                    b.Property<DateTime>("ShippingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TrackingNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ShippingID");

                    b.ToTable("ShippingDetail");
                });

            modelBuilder.Entity("API.Model.StockTake", b =>
                {
                    b.Property<int>("StockTakeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StockTakeID"));

                    b.Property<DateTime>("StockTake_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("StockTake_Notes")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("StockTakeID");

                    b.ToTable("StockTake");
                });

            modelBuilder.Entity("API.Model.StockTake_Item", b =>
                {
                    b.Property<int>("StockTake_ItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StockTake_ItemID"));

                    b.Property<int>("StockTakeID")
                        .HasColumnType("int");

                    b.Property<int>("Stocktake_Difference")
                        .HasColumnType("int");

                    b.HasKey("StockTake_ItemID");

                    b.HasIndex("StockTakeID");

                    b.ToTable("StockTakeItem");
                });

            modelBuilder.Entity("API.Model.Supplier", b =>
                {
                    b.Property<int>("SupplierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplierID"));

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SupplierID");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("API.Model.SupplierOrder", b =>
                {
                    b.Property<int>("SupplierOrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplierOrderID"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity_Ordered")
                        .HasColumnType("int");

                    b.HasKey("SupplierOrderID");

                    b.ToTable("SupplierOrder");
                });

            modelBuilder.Entity("API.Model.SupplierPayment", b =>
                {
                    b.Property<int>("SupplierPaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplierPaymentID"));

                    b.Property<double>("AmountPaid")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("SupplierPaymentID");

                    b.ToTable("SupplierPayment");
                });

            modelBuilder.Entity("API.Model.Ticket", b =>
                {
                    b.Property<int>("TicketID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketID"));

                    b.Property<DateTime>("ExpiredDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("TicketPrice")
                        .HasColumnType("float");

                    b.HasKey("TicketID");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("API.Model.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("UserEmail")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserPassword")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("API.Model.VAT", b =>
                {
                    b.Property<int>("VATID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VATID"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Percentage")
                        .HasColumnType("float");

                    b.HasKey("VATID");

                    b.ToTable("VAT");
                });

            modelBuilder.Entity("API.Model.Varietal", b =>
                {
                    b.Property<int>("VarietalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VarietalID"));

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("VarietalID");

                    b.ToTable("Varietal");
                });

            modelBuilder.Entity("API.Model.Wine", b =>
                {
                    b.Property<int>("WineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WineID"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Restock_Limit")
                        .HasColumnType("int");

                    b.Property<string>("Vintage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WinetastingNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image_URL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WineID");

                    b.ToTable("Wine");
                });

            modelBuilder.Entity("API.Model.WineDiscount", b =>
                {
                    b.Property<int>("WineDiscountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WineDiscountID"));

                    b.Property<DateTime>("End_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Start_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("WineDiscountID");

                    b.ToTable("WineDiscount");
                });

            modelBuilder.Entity("API.Model.WinePrice", b =>
                {
                    b.Property<int>("WinePriceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WinePriceID"));

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("WinePriceID");

                    b.ToTable("WinePrice");
                });

            modelBuilder.Entity("API.Model.WineType", b =>
                {
                    b.Property<int>("WineTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WineTypeID"));

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("WineTypeID");

                    b.ToTable("WineType");
                });

            modelBuilder.Entity("API.Model.Wishlist", b =>
                {
                    b.Property<int>("WishlistID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WishlistID"));

                    b.HasKey("WishlistID");

                    b.ToTable("Wishlist");
                });

            modelBuilder.Entity("API.Model.WishlistItem", b =>
                {
                    b.Property<int>("WishlistItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WishlistItemID"));

                    b.HasKey("WishlistItemID");

                    b.ToTable("WishlistItem");
                });

            modelBuilder.Entity("API.Model.WriteOff", b =>
                {
                    b.Property<int>("WriteOffID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WriteOffID"));

                    b.Property<DateTime>("WriteOff_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("WriteOffID");

                    b.ToTable("WriteOff");
                });

            modelBuilder.Entity("API.Model.WriteOffItem", b =>
                {
                    b.Property<int>("WriteOffItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WriteOffItemID"));

                    b.Property<int>("WriteOff_Quantity")
                        .HasColumnType("int");

                    b.HasKey("WriteOffItemID");

                    b.ToTable("WriteOffItem");
                });

            modelBuilder.Entity("API.Model.WriteOff_Reason", b =>
                {
                    b.Property<int>("WriteOff_ReasonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WriteOff_ReasonID"));

                    b.Property<DateTime>("Date_of_last_update")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("WriteOff_ReasonID");

                    b.ToTable("WriteOffReason");
                });

            modelBuilder.Entity("API.Model.Inventory", b =>
                {
                    b.HasOne("API.Model.Wine", "Wine")
                        .WithMany()
                        .HasForeignKey("WineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Wine");
                });

            modelBuilder.Entity("API.Model.StockTake_Item", b =>
                {
                    b.HasOne("API.Model.StockTake", "StockTake")
                        .WithMany("StockTake_Items")
                        .HasForeignKey("StockTakeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StockTake");
                });

            modelBuilder.Entity("API.Model.StockTake", b =>
                {
                    b.Navigation("StockTake_Items");
                });
#pragma warning restore 612, 618
        }
    }
}
