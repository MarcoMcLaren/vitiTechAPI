using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }

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
