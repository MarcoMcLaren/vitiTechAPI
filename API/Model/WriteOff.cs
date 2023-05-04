using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API.Model
{
    public class WriteOff
    {
        [Key]
        public int WriteOffID { get; set; }

        public DateTime WriteOff_Date { get; set; }

        [JsonIgnore]
        public List<WriteOffItem> WriteOffItems { get; set; }

        [ForeignKey("EmployeeID")]
        public int EmployeeID { get; set; }

        [JsonIgnore]
        public Employee Employee { get; set; }
    }
}
