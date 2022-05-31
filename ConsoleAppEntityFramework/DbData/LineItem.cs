using System.ComponentModel.DataAnnotations;

namespace ConsoleAppEntityFramework.DbData
{
    public class LineItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Product Product { get; set; }
        [Required]
        public int Count { get; set; }
        public double PriceSum { get; set; }
    }
}
