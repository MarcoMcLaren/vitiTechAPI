using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class SupplierPayment
    {
        [Key]
        public int SupplierPaymentID { get; set; }

        [ForeignKey("SupplierOrderID")]
        public int SupplierOrderID { get; set; }
        public SupplierOrder SupplierOrder { get; set; }

        public double AmountPaid { get; set; }

        public DateTime Date { get; set; }
    }
}
