using System.ComponentModel.DataAnnotations;

namespace Pizza_Projektet___cafe_luccas.Models
{
    public class Customers
    {
        //culomns in table Customers
        [Key]
        public int CustomerID { get; set; }  // primary key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
    }
}
