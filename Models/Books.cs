using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment5.Models
{
    public class Books
    {
        [Key,Required]
        public string BookID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        public string ISBN { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Price { get; set; }
    }
}
