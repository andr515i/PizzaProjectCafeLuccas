
using System.ComponentModel.DataAnnotations;

namespace Pizza_Projektet___cafe_luccas.Models
{
    public class PizzaMenu
    {
        [Key]
        public int PizzaID { get; set; }
        public string PizzaName { get; set; } 
        public string Toppings { get; set; } 
    }
}
