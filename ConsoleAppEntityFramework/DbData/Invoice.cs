using System.ComponentModel.DataAnnotations;

namespace ConsoleAppEntityFramework.DbData
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Action { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public LineItem LineItem { get; set; }
        public Employee IssuedBy { get; set; }
    }
}
