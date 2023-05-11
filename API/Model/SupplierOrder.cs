using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class SupplierOrder
    {
        [Key]
        public int SupplierOrderID { get; set; }

        public int Quantity_Ordered { get; set; }

        public DateTime Date { get; set; }

        [ForeignKey("WineID")]
        public int WineID { get; set; }
        public Wine Wine { get; set; }

        [ForeignKey("SupplierID")]
        public int SupplierID { get; set; }
        public Supplier Supplier { get; set; }

        [ForeignKey("SupplierPaymentID")]
        public int SupplierPaymentID { get; set; }
        public SupplierPayment SupplierPayment { get; set; }
    }
}
