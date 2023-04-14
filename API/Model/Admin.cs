using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }

        [ForeignKey("SuperUserID")]
        public int SuperUserID { get; set; }
        public SuperUser SuperUser { get; set; }

        [ForeignKey("UserID")]
        public int UserID { get; set; }
        public User User { get; set; }

        [ForeignKey("AddressID")]
        public int AddressID { get; set; }
        public Address Address { get; set; }

        [ForeignKey("AdminPrivilegesID")]
        public int AdminPrivilegesID { get; set; }
        public Admin_Privileges AdminPrivileges { get; set; }

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
    }
}
