using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string PhoneNumber { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }
    }
}
