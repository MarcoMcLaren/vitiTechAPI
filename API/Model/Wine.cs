using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Wine
    {
        [Key]
        public int WineID { get; set; }

        [ForeignKey("AdminID")]
        public int AdminID { get; set; }
        public Admin Admin { get; set; }

        [ForeignKey("WineTypeID")]
        public int WineTypeID { get; set; }
        public WineType WineType { get; set; }

        [ForeignKey("VarietalID")]
        public int VarietalID { get; set; }
        public Varietal Varietal { get; set; }

        [ForeignKey("WinePriceID")]
        public int WinePriceID { get; set; }
        public WinePrice WinePrice { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        [MaxLength(50)]
        public string Vintage { get; set; }

        [Range(0, 999)]
        public int RestockLimit { get; set; }

        [MaxLength(255)]
        public string ImageURL { get; set; }
        public string WineTastingNote { get; set; }
    }
}
