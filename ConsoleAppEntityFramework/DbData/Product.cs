using System.ComponentModel.DataAnnotations;

namespace ConsoleAppEntityFramework.DbData
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string OriginCountry { get; set; }
    }
}
