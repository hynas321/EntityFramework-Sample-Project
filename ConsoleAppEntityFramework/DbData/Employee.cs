using System.ComponentModel.DataAnnotations;

namespace ConsoleAppEntityFramework.DbData
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        public string Post { get; set; }
    }
}
