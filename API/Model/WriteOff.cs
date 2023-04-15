using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class WriteOff
    {
        [Key]
        public int WriteOffID { get; set; }

        public DateTime WriteOff_Date { get; set; }

        public List<WriteOffItem> WriteOffItems { get; set; }

        [ForeignKey("EmployeeID")]
        public int EmployeeID { get; set; }

        public Employee Employee { get; set; }
    }
}
