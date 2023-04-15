using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        public DateTime Order_Date { get; set; }
    }
}
