using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Wishlist
    {
        [Key]
        public int WishlistID { get; set; }

    }
}
