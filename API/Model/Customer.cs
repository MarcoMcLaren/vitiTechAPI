using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }


        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(50)]
        public string First_Name { get; set; }

        [MaxLength(50)]
        public string Last_Name { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string Phone_Number { get; set; }

        [MaxLength(13)]
        public string ID_Number { get; set; }

        [MaxLength(15)]
        public string Gender { get; set; }

        public DateTime Date_Created { get; set; }

        public DateTime Date_of_last_update { get; set; }

        public Wishlist Wishlist { get; set; }



    }
}
