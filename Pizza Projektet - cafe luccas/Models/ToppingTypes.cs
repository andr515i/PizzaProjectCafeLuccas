using System.ComponentModel.DataAnnotations;

namespace Pizza_Projektet___cafe_luccas.Models
{
    public class ToppingTypes
    {
        [Key]
        public int ToppingTypeID { get; set; }
        public bool? IsDairy { get; set; }
        public bool? IsMeat{ get; set; }
        public bool? IsVeggie{ get; set; }
        public bool? IsDipping{ get; set; }
        public bool? IsSpicy{ get; set; }
        public bool? IsASpice{ get; set; }
    }
}
