﻿using API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace API.Data
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        //Not deleted
        //.OnDelete(DeleteBehavior.Restrict);

        //Delete
        //.OnDelete(DeleteBehavior.Cascade);

        //INF 370 team git test

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StockTake>()
            .HasMany<StockTake_Item>(s => s.StockTake_Items)
            .WithOne(si => si.StockTake)
            .HasForeignKey(si => si.StockTakeID)
            .OnDelete(DeleteBehavior.Restrict);

            //Wine and Inventory
            modelBuilder.Entity<Inventory>()
            .HasOne<Wine>(i => i.Wine)
            .WithMany(w => w.Inventories)
            .HasForeignKey(i => i.WineID)
            .OnDelete(DeleteBehavior.Restrict);

            //Wine and Employee
            //modelBuilder.Entity<Wine>()
            // .HasOne<Employee>(w => w.Employee)
            // .WithMany(e => e.Wines)
            // .HasForeignKey(w => w.EmployeeID)
            // .OnDelete(DeleteBehavior.Restrict);

            //Employee and User
            modelBuilder.Entity<Employee>()
             .HasOne(e => e.User)
             .WithOne(u => u.Employee)
             .HasForeignKey<Employee>(e => e.UserID)
             .OnDelete(DeleteBehavior.Cascade);

            //Customer and Order
            modelBuilder.Entity<Order>()
            .HasOne(o => o.Customer)
            .WithMany(c => c.Orders)
            .HasForeignKey(o => o.CustomerID)
            .OnDelete(DeleteBehavior.Restrict);

            //Order and OrderStatus
            modelBuilder.Entity<Order>()
             .HasOne(o => o.OrderStatus)
             .WithMany(os => os.Orders)
             .HasForeignKey(o => o.OrderStatusID)
             .OnDelete(DeleteBehavior.Restrict);

            //Inventory and stockTake_Item
            modelBuilder.Entity<Inventory>()
            .HasMany<StockTake_Item>(i => i.StockTake_Items)
            .WithOne(s => s.Inventory)
            .HasForeignKey(s => s.InventoryID)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Wine>()
            .HasMany(s => s.SupplierOrders)
            .WithOne(w => w.Wine)
            .HasForeignKey(w => w.WineID)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SupplierOrder>()
            .HasOne<Supplier>(so => so.Supplier)
            .WithMany(s => s.SupplierOrders)
            .HasForeignKey(so => so.SupplierID)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SupplierOrder>()
             .HasOne(s => s.SupplierPayment)
             .WithOne(sp => sp.SupplierOrder)
             .HasForeignKey<SupplierPayment>(sp => sp.SupplierOrderID)
             .OnDelete(DeleteBehavior.Restrict);

            //Wine and WineType
            modelBuilder.Entity<Wine>()
             .HasOne<WineType>(w => w.WineType)
             .WithMany(wt => wt.Wines)
             .HasForeignKey(w => w.WineTypeID)
             .OnDelete(DeleteBehavior.Restrict);

            //Wine and WineVarietal
            modelBuilder.Entity<Wine>()
            .HasOne(w => w.Varietal)
            .WithMany(v => v.Wines)
            .HasForeignKey(w => w.VarietalID)
            .OnDelete(DeleteBehavior.Restrict);

            //OrderItem and Order
            modelBuilder.Entity<OrderItem>()
             .HasOne(oi => oi.Order)
             .WithMany(o => o.OrderItems)
             .HasForeignKey(oi => oi.OrderID)
             .OnDelete(DeleteBehavior.Cascade);

            //OrderItem and Wine
            modelBuilder.Entity<OrderItem>()
             .HasOne(oi => oi.Wine)
             .WithMany(w => w.OrderItems)
             .HasForeignKey(oi => oi.WineID)
             .OnDelete(DeleteBehavior.Restrict);

            //OrderItem and Refund
            modelBuilder.Entity<OrderItem>()
            .HasMany(o => o.Refunds)
            .WithOne(r => r.OrderItem)
            .HasForeignKey(r => r.OrderItemID)
            .OnDelete(DeleteBehavior.Restrict);

            //Refund and RefundResponse
            modelBuilder.Entity<Refund>()
            .HasOne(r => r.RefundResponse)
            .WithMany(rr => rr.Refunds)
            .HasForeignKey(r => r.RefundResponseID)
            .OnDelete(DeleteBehavior.Restrict);

            //Refund and RefundReason
            modelBuilder.Entity<Refund>()
            .HasOne(r => r.RefundReason)
            .WithMany(rr => rr.Refunds)
            .HasForeignKey(r => r.RefundReasonID);

            //RefundReason and RefundType
            modelBuilder.Entity<RefundReason>()
            .HasOne(rr => rr.RefundType)
            .WithMany(rt => rt.RefundReasons)
            .HasForeignKey(rr => rr.RefundTypeID)
            .OnDelete(DeleteBehavior.Restrict);

            //Wine and WriteOffItem
            modelBuilder.Entity<Wine>()
             .HasMany(w => w.WriteOffItems)
             .WithOne(wi => wi.Wine)
             .HasForeignKey(wi => wi.WineID)
             .OnDelete(DeleteBehavior.Restrict);

            //WriteOffReason and WriteOffItem
            modelBuilder.Entity<WriteOffItem>()
             .HasOne<WriteOff_Reason>(woi => woi.WriteOff_Reason)
             .WithMany(wor => wor.WriteOffItems)
             .HasForeignKey(woi => woi.WriteOffReasonID)
             .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<WriteOff>()
            .HasMany(w => w.WriteOffItems)
            .WithOne(wi => wi.WriteOff)
            .HasForeignKey(wi => wi.WriteOffID);

            //WishlistItem and Wine
            modelBuilder.Entity<WishlistItem>()
             .HasOne(wli => wli.Wine)
             .WithMany(w => w.WishlistItems)
             .HasForeignKey(wli => wli.WineID)
             .OnDelete(DeleteBehavior.Cascade);

            //WishListitem and Wishlist
            modelBuilder.Entity<WishlistItem>()
            .HasOne(wli => wli.Wishlist)
            .WithMany(wl => wl.WishlistItems)
            .HasForeignKey(wli => wli.WishlistID)
            .OnDelete(DeleteBehavior.Cascade);

            //Customer and Wishlist
            modelBuilder.Entity<Wishlist>()
            .HasOne(wl => wl.Customer)
            .WithOne(c => c.Wishlist)
            .HasForeignKey<Wishlist>(wl => wl.CustomerID)
            .OnDelete(DeleteBehavior.Cascade);

            //Order and ShippingDetails
            modelBuilder.Entity<Order>()
            .HasOne(o => o.ShippingDetails)
            .WithOne(sd => sd.Order)
            .HasForeignKey<ShippingDetails>(sd => sd.OrderID)
            .OnDelete(DeleteBehavior.Cascade);

            //Order and OrderPayment
            modelBuilder.Entity<Order>()
             .HasOne(o => o.OrderPayment)
             .WithOne(op => op.Order)
             .HasForeignKey<OrderPayment>(op => op.OrderID)
             .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<WriteOff>()
            .HasOne(w => w.Employee)
            .WithMany(e => e.WriteOffs)
            .HasForeignKey(w => w.EmployeeID)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Event>()
            .HasOne(e => e.EventPrice)
            .WithOne(ep => ep.Event)
            .HasForeignKey<Event>(e => e.EventPriceID)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Event>()
            .HasOne(e => e.EventType)
            .WithMany(et => et.Events)
            .HasForeignKey(e => e.EventTypeID)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Booking>()
            .HasOne(b => b.Event)
            .WithMany(e => e.Bookings)
            .HasForeignKey(b => b.EventId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Booking>()
            .HasMany(b => b.Tickets)
            .WithOne(t => t.Booking)
            .HasForeignKey(t => t.BookingId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Booking>()
            .HasOne(b => b.BookingPayment)
            .WithOne(p => p.Booking)
            .HasForeignKey<BookingPayment>(p => p.BookingId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Booking>()
            .HasOne(b => b.Customer)
            .WithMany(c => c.Bookings)
            .HasForeignKey(b => b.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EventReview>()
            .HasOne(r => r.Customer)
            .WithMany(c => c.EventReviews)
            .HasForeignKey(r => r.CustomerID)
            .OnDelete(DeleteBehavior.Restrict);

            //User and Customer
            modelBuilder.Entity<User>()
            .HasOne(u => u.Customer)
            .WithMany(c => c.Users)
            .HasForeignKey(u => u.CustomerID)
            .OnDelete(DeleteBehavior.Cascade);

            //User and SuperUser
            modelBuilder.Entity<SuperUser>()
            .HasOne(su => su.User)
            .WithMany(u => u.SuperUsers)
            .HasForeignKey(su => su.UserID)
            .OnDelete(DeleteBehavior.Cascade);

            //Employee and SystemPrivilege
            modelBuilder.Entity<Employee>()
            .HasOne(e => e.SystemPrivilege)
            .WithOne(sp => sp.Employee)
            .HasForeignKey<Employee>(e => e.SystemPrivilegeID)
            .OnDelete(DeleteBehavior.Restrict);

            //SystemPrivelege and SuperUser
            modelBuilder.Entity<SuperUser>()
            .HasOne(su => su.SystemPrivilege)
            .WithOne(sp => sp.SuperUser)
            .HasForeignKey<SystemPrivilege>(sp => sp.SystemPrivilegeID)
            .OnDelete(DeleteBehavior.Restrict);

            //SuperUser and Employee
            modelBuilder.Entity<Employee>()
            .HasOne(e => e.SuperUser)
            .WithMany(su => su.Employees)
            .HasForeignKey(e => e.SuperUserID)
            .OnDelete(DeleteBehavior.Restrict);

            //SuperUser and Address
            modelBuilder.Entity<SuperUser>()
            .HasOne(s => s.Address)
            .WithOne(a => a.SuperUser)
            .HasForeignKey<Address>(a => a.SuperUserID);

            //Address and Employee
            modelBuilder.Entity<Address>()
            .HasOne(a => a.Employee)
            .WithOne(e => e.Address)
            .HasForeignKey<Address>(a => a.EmployeeID)
            .OnDelete(DeleteBehavior.Restrict);

            //Address and Employee
            modelBuilder.Entity<Address>()
            .HasOne(a => a.Province)
            .WithMany()
            .HasForeignKey(a => a.ProvinceID)
            .OnDelete(DeleteBehavior.Restrict);

            //EbventLocation Address
            modelBuilder.Entity<EventLocation>()
            .HasOne(e => e.Address)
            .WithOne(a => a.EventLocation)
            .HasForeignKey<EventLocation>(e => e.AddressID)
            .OnDelete(DeleteBehavior.Restrict);

            //SuperUser and EventLocation
            modelBuilder.Entity<SuperUser>()
            .HasMany(su => su.EventLocations)
            .WithOne(el => el.SuperUser)
            .HasForeignKey(el => el.SuperUserID)
            .OnDelete(DeleteBehavior.Restrict);

            //Event and EarlyBird
            modelBuilder.Entity<Event>()
            .HasOne(e => e.EarlyBird)
            .WithOne(eb => eb.Event)
            .HasForeignKey<EarlyBird>(eb => eb.EventID);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Blacklist> Blacklists { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingPayment> BookingPayments { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Discount> Discounts{ get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventLocation> EventLocations { get; set; }
        public DbSet<EventPrice> EventPrices { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<EventReview> EventReviews{ get; set; }
        public DbSet<EarlyBird> EarlyBird { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderPayment> OrderPayments { get; set; }
        public DbSet<Refund> Refunds { get; set; }
        public DbSet<RefundReason> RefundReasons { get; set; }
        public DbSet<RefundResponse> RefundResponses { get; set; }
        public DbSet<RefundType> RefundTypes { get; set; }
        public DbSet<ShippingDetails> ShippingDetails { get; set; }
        public DbSet<StockTake> StockTakes { get; set; }
        public DbSet<StockTake_Item> StockTakeItems { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierOrder> SupplierOrders { get; set; }
        public DbSet<SupplierPayment> SupplierPayments { get; set; }
        public DbSet<SystemPrivilege> SystemPrivileges { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<VAT> VATs { get; set; }
        public DbSet<Varietal> Varietals { get; set; }
        public DbSet<Wine> Wines { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<WishlistItem> WishlistItems { get; set; }
        public DbSet<WineType> WineTypes { get; set; }
        public DbSet<WriteOff> WriteOffs { get; set; }
        public DbSet<WriteOffItem> WriteOffItems { get; set; }
        public DbSet<WriteOff_Reason> WriteOffReasons { get; set; }
        public DbSet<SuperUser> SuperUser { get; set; }
      
    }
}
