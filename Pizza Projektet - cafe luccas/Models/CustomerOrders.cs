using System.ComponentModel.DataAnnotations;

namespace Pizza_Projektet___cafe_luccas.Models

{
    public class CustomerOrders
    {

        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int pizzaID { get; set; }

        // We require a key so we can differentiate between other objects
        [Key]
        public int COID { get; set;}
    }
}