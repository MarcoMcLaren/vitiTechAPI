using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class WriteOffItem
    {
        [Key]
        public int WriteOffItemID { get; set; }

        public int WriteOff_Quantity { get; set; }
    }
}
