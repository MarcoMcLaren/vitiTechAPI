using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class WriteOff_Reason
    {
        [Key]
        public int WriteOff_ReasonID { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public DateTime Date_of_last_update { get; set; }

        [ForeignKey("WriteOffItemID")]
        public int WriteOffItemID { get; set; }
        public WriteOffItem WriteOffItem { get; set; }

        public List<WriteOffItem> WriteOffItems { get; set; }
    }
}
