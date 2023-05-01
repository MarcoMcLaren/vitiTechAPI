using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Wine
    {
        [Key]
        public int WineID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Vintage { get; set; }

        [Range(0, 999)]
        public int RestockLimit { get; set; }

        [StringLength(255)]
        public string ImageUrl { get; set; }

        [StringLength(255)]
        public string WineTastingNote { get; set; }

        public double WinePrice { get; set; }

        [ForeignKey("WineTypeID")]
        public int WineTypeID { get; set; }
        public WineType WineType { get; set; }

        [ForeignKey("VarietalID")]
        public int VarietalID { get; set; }
        public Varietal Varietal { get; set; }

        [ForeignKey("EmployeeID")]
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }

        public List<Inventory> Inventories { get; set; }
        public List<WineDiscount> WineDiscounts { get; set; }
        public List<SupplierOrder> SupplierOrders { get; set; }
        public List<WriteOffItem> WriteOffItems { get; set; }
        public List<WishlistItem> WishlistItems { get; set; }
        public List<OrderItem> OrderItems { get; set; }

    }
}
