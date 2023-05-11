using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class WishlistItem
    {
        [Key]
        public int WishlistItemID { get; set; }

        [ForeignKey("WineID")]
        public int WineID { get; set; }
        public Wine Wine { get; set; }

        [ForeignKey("WishlistID")]
        public int WishlistID { get; set; }
        public Wishlist Wishlist { get; set; }
    }
}
