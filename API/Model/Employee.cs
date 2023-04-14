using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [ForeignKey("AdminID")]
        public int AdminID { get; set; }
        public Admin Admin { get; set; }

        [MaxLength(50)]
        public string First_Name { get; set; }

        [MaxLength(50)]
        public string Last_Name { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(10)]
        public string Phone_Number { get; set; }

        [MaxLength(13)]
        public string ID_Number { get; set; }

        public DateTime Hire_Date { get; set; }
    }
}
