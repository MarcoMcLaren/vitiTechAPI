using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class WishlistItem
    {
        [Key]
        public int WishlistItemID { get; set; }

    }
}
