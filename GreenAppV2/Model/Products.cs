
using System.ComponentModel.DataAnnotations;

namespace GreenAppV2.Model
{
    public class Products
    {
        [Key] // Detta indikerar att ProductId är primärnyckeln
        public int ProductId { get; set; }

        public int UserId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategory { get; set; }
        public int Price { get; set; }
    }
}
