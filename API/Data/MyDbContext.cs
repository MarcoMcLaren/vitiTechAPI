using API.Model;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Admin_Privileges> AdminPrivileges { get; set; }
        public DbSet<Blacklist> Blacklists { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingPayment> BookingPayments { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<EarlyBird> EarlyBirds { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventLocation> EventLocations { get; set; }
        public DbSet<EventPrice> EventPrices { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<EventReview> EventReviews { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
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
        public DbSet<SuperUser> SuperUsers { get; set; }
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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Wine>()
            .HasOne(w => w.WinePrice)
            .WithOne(wp => wp.Wine)
            .HasForeignKey<WinePrice>(wp => wp.WineID);

        }
    }
}
