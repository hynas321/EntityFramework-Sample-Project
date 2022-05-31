using ConsoleAppEntityFramework.AbstractData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
