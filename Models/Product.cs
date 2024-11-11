using System.ComponentModel.DataAnnotations;

namespace Sashiel_ST10028058_CLDV6212_POE.Models
{

    public class Product
    {

        [Key]
        public int Product_Id { get; set; }
        [Required]
        public string? Product_Name { get; set; }
        [Required]
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        [Required]
        public double Product_Price { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
