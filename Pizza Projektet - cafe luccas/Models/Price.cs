using System.ComponentModel.DataAnnotations;

namespace Pizza_Projektet___cafe_luccas.Models
{
    public class Price
    {
        // columns in table Price
        [Key]
        public int PriceID { get; set; } //primary key
        public int PriceTag { get; set; }
    }
}
