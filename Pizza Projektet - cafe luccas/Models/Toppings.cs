using System.ComponentModel.DataAnnotations;

namespace  Pizza_Projektet___cafe_luccas.Models
{
    public class Toppings
    {
        [Key]
        public int ToppingID { get; set; }
        public ToppingTypes ToppingTypeID { get; set; }
        public string ToppingName { get; set; }
        public int PriceID { get; set; }
    }
}
