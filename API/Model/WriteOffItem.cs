using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class WriteOffItem
    {
        [Key]
        public int WriteOffItemID { get; set; }

        [ForeignKey("WriteOffID")]
        public int WriteOffID { get; set; }
        public WriteOff WriteOff { get; set; }

        [ForeignKey("WineID")]
        public int WineID { get; set; }
        public Wine Wine { get; set; }

        [ForeignKey("WriteOff_ReasonID")]
        public int WriteOff_ReasonID { get; set; }
        public WriteOff_Reason WriteOff_Reason { get; set; }

        public int WriteOff_Quantity { get; set; }
    }
}
