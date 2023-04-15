using API.Model;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StockTake_Item>()
             .HasOne(si => si.StockTake)
             .WithMany(st => st.StockTake_Items)
             .HasForeignKey(si => si.StockTakeID);

            modelBuilder.Entity<Inventory>()
            .HasOne<Wine>(i => i.Wine)
            .WithMany(w => w.Inventories)
            .HasForeignKey(i => i.WineID);

            modelBuilder.Entity<Wine>()
            .HasMany(w => w.WineDiscounts)
            .WithOne(wd => wd.Wine)
            .HasForeignKey(wd => wd.WineID);

            modelBuilder.Entity<WineDiscount>()
            .HasOne<Discount>(wd => wd.Discount)
            .WithMany(d => d.WineDiscounts)
            .HasForeignKey(wd => wd.DiscountID);

            modelBuilder.Entity<Wine>()
            .HasMany(s => s.SupplierOrders)
            .WithOne(w => w.Wine)
            .HasForeignKey(w => w.WineID);

            modelBuilder.Entity<SupplierOrder>()
            .HasOne<Supplier>(so => so.Supplier)
            .WithMany(s => s.SupplierOrders)
            .HasForeignKey(so => so.SupplierID);

            modelBuilder.Entity<SupplierOrder>()
             .HasOne(s => s.SupplierPayment)
             .WithOne(sp => sp.SupplierOrder)
             .HasForeignKey<SupplierPayment>(sp => sp.SupplierOrderID);

            modelBuilder.Entity<Wine>()
            .HasOne<WineType>(w => w.WineType)
            .WithMany(wt => wt.Wines)
            .HasForeignKey(w => w.WineTypeID)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Wine>()
            .HasOne(wp => wp.WinePrice)
            .WithOne(w => w.Wine)
            .HasForeignKey<WinePrice>(wp => wp.WineID);

            modelBuilder.Entity<Wine>()
            .HasOne(w => w.Varietal)
            .WithMany(v => v.Wines)
            .HasForeignKey(w => w.VarietalID);

            modelBuilder.Entity<Wine>()
            .HasOne(o => o.OrderItem)
            .WithOne(w => w.Wine)
            .HasForeignKey<OrderItem>(w => w.WineID);

            modelBuilder.Entity<OrderItem>()
            .HasMany(o => o.Refunds)
            .WithOne(r => r.OrderItem)
            .HasForeignKey(r => r.OrderItemID);

            modelBuilder.Entity<Refund>()
            .HasOne(r => r.RefundResponse)
            .WithMany(rr => rr.Refunds)
            .HasForeignKey(r => r.RefundResponseID);

            modelBuilder.Entity<Refund>()
            .HasOne(r => r.RefundReason)
            .WithMany(rr => rr.Refunds)
            .HasForeignKey(r => r.RefundReasonID);

            modelBuilder.Entity<RefundReason>()
             .HasOne(rr => rr.RefundType)
             .WithMany(rt => rt.RefundReasons)
             .HasForeignKey(rr => rr.RefundTypeID);

            modelBuilder.Entity<Wine>()
            .HasMany(w => w.WriteOffItems)
            .WithOne(wi => wi.Wine)
            .HasForeignKey(wi => wi.WineID);

            modelBuilder.Entity<WriteOffItem>()
            .HasOne<WriteOff_Reason>(w => w.WriteOff_Reason)
            .WithOne(wr => wr.WriteOffItem)
            .HasForeignKey<WriteOff_Reason>(wr => wr.WriteOffItemID);

            modelBuilder.Entity<WriteOff>()
            .HasMany(w => w.WriteOffItems)
            .WithOne(wi => wi.WriteOff)
            .HasForeignKey(wi => wi.WriteOffID);

            modelBuilder.Entity<WishlistItem>()
            .HasOne(wli => wli.Wine)
            .WithMany(w => w.WishlistItems)
            .HasForeignKey(wli => wli.WineID);

            modelBuilder.Entity<WishlistItem>()
            .HasOne(wli => wli.Wishlist)
            .WithMany(wl => wl.WishlistItems)
            .HasForeignKey(wli => wli.WishlistID);

            modelBuilder.Entity<Wishlist>()
            .HasOne(wl => wl.Customer)
            .WithOne(c => c.Wishlist)
            .HasForeignKey<Wishlist>(wl => wl.CustomerID);

            modelBuilder.Entity<Wine>()
            .HasOne(a => a.Admin)
            .WithMany(w => w.Wines)
            .HasForeignKey(a => a.AdminID);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Blacklist> Blacklists { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingPayment> BookingPayments { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Discount> Discounts{ get; set; }
        public DbSet<EarlyBird> EarlyBirds { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventLocation> EventLocations { get; set; }
        public DbSet<EventPrice> EventPrices { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<EventReview> EventReviews{ get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderPayment> OrderPayments { get; set; }
        public DbSet<Refund> Refunds { get; set; }
        public DbSet<RefundReason> RefundReasons { get; set; }
        public DbSet<RefundResponse> RefundResponses { get; set; }
        public DbSet<RefundType> RefundTypes { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<ShippingDetails> ShippingDetails { get; set; }
        public DbSet<StockTake> StockTakes { get; set; }
        public DbSet<StockTake_Item> StockTakeItems { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierOrder> SupplierOrders { get; set; }
        public DbSet<SupplierPayment> SupplierPayments { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<VAT> VATs { get; set; }
        public DbSet<Varietal> Varietals { get; set; }
        public DbSet<Wine> Wines { get; set; }
        public DbSet<WineDiscount> WineDiscounts { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<WishlistItem> WishlistItems { get; set; }
        public DbSet<WinePrice> WinePrices { get; set; }
        public DbSet<WineType> WineTypes { get; set; }
        public DbSet<WriteOff> WriteOffs { get; set; }
        public DbSet<WriteOffItem> WriteOffItems { get; set; }
        public DbSet<WriteOff_Reason> WriteOffReasons { get; set; }
      
    }
}
