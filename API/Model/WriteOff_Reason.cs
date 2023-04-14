using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class WriteOff_Reason
    {
        [Key]
        public int WriteOff_ReasonID { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public DateTime Date_of_last_update { get; set; }
    }
}
