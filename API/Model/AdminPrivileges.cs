using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class AdminPrivileges
    {
        [Key]
        public int AdminPrivilegesID { get; set; }

        [MaxLength(255)]
        public string Privilege_Description { get; set; }
    }
}
