using System.ComponentModel.DataAnnotations;

namespace Pizza_Projektet___cafe_luccas.Models
{
    public class Price
    {
        [Key]
        public int PriceID { get; set; }
        public int PriceTag { get; set; }
    }
}
