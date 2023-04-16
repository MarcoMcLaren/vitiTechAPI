using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }

        [ForeignKey("AdminPrivilegesID")]
        public int AdminPrivilegesID { get; set; }
        public AdminPrivileges AdminPrivileges { get; set; }


        [MaxLength(50)]
        public string First_Name { get; set; }

        [MaxLength(50)]
        public string Last_Name { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string Phone_Number { get; set; }

        [MaxLength(13)]
        public long ID_Number { get; set; }

        public DateTime Hire_Date { get; set; }

        public List<Wine> Wines { get; set; }

        public List<Employee> Employees { get; set; }

        public List<EventLocation> EventLocations { get; set; }

        public List<Event> Events { get; set; }

        public List<SuperUser> SuperUsers { get; set; }
    }
}
