using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API.Model
{
    public class SuperUser
    {
        [Key]
        [Required]
        public int SuperUserID { get; set; }

        [MaxLength(50)]
        [Required]
        public string First_Name { get; set; }

        [MaxLength(50)]
        [Required]
        public string Last_Name { get; set; }

        [MaxLength(50)]
        [Required]
        public string Email { get; set; }

        [MaxLength(50)]
        [Required]
        public string Phone_Number { get; set; }

        [MaxLength(13)]
        [Required]
        public string ID_Number { get; set; }

        [Required]
        public DateTime Hire_Date { get; set; }

        [ForeignKey("UserID")]
        public int UserID { get; set; }
        public User User { get; set; }

        [ForeignKey("SystemPrivilegeID")]
        public int SystemPrivilegeID { get; set; }
        public SystemPrivilege SystemPrivilege { get; set; }

        [JsonIgnore]
        public List<Employee> Employees { get; set; }

        [ForeignKey("Address")]
        public int AddressID { get; set; }
        public Address Address { get; set; }

        [JsonIgnore]
        public List<EventLocation> EventLocations { get; set; }
    }
}
