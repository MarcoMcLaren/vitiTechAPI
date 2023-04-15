using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Wine
    {
        [Key]
        public int WineID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Vintage { get; set; }
        public int Restock_Limit { get; set; }
        public string image_URL { get; set; }
        public string WinetastingNote { get; set; }

        [ForeignKey("WineTypeID")]
        public int WineTypeID { get; set; }
        public WineType WineType { get; set; }

        [ForeignKey("WinePriceID ")]
        public int WinePriceID { get; set; }
        public WinePrice WinePrice { get; set; }

        [ForeignKey("VarietalID")]
        public int VarietalID { get; set; }
        public Varietal Varietal { get; set; }

        [ForeignKey("OrderItemID")]
        public int OrderItemID { get; set; }
        public OrderItem OrderItem { get; set; }

        [ForeignKey("AdminID")]
        public int AdminID { get; set; }
        public Admin Admin { get; set; }

        public List<Inventory> Inventories { get; set; }
        public List<WineDiscount> WineDiscounts { get; set; }
        public List<SupplierOrder> SupplierOrders { get; set; }
        public List<WriteOffItem> WriteOffItems { get; set; }
        public List<WishlistItem> WishlistItems { get; set; }

    }
}
