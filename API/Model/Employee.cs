using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API.Model
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

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
        [JsonIgnore]
        public List<WriteOff> WriteOffs { get; set; }
        [JsonIgnore]
        public List<Wine> Wines { get; set; }

        [ForeignKey("UserID")]
        public int UserID { get; set; }
        public User User { get; set; }

        [ForeignKey("SystemPrivilegeID")]
        public int SystemPrivilegeID { get; set; }
        public SystemPrivilege SystemPrivilege { get; set; }

        [ForeignKey("SuperUserID")]
        public int SuperUserID { get; set; }
        public SuperUser SuperUser { get; set; }

        public Address Address { get; set; }
    }
}
