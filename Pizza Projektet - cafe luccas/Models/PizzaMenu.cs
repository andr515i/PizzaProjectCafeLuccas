
using System.ComponentModel.DataAnnotations;

namespace Pizza_Projektet___cafe_luccas.Models
{
    public class PizzaMenu
    {
        // columns in table PizzaMenu
        [Key]
        public int PizzaID { get; set; } // primary key 
        public string PizzaName { get; set; } 
        public string Toppings { get; set; } 
    }
}
