using System;
using System.ComponentModel.DataAnnotations;

namespace Pizza_Projektet___cafe_luccas.Models
{
    public class Orders
    {
        //columns in table Orders
        [Key]
        public int OrderID { get; set; } // primary key
        public DateTime OrderDate { get; set; }
        public bool? IsFinished { get; set; }
    }
}
