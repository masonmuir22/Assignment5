using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment5.Models
{
    public class Books
    {
        [Key]
        public int BookID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string AuthorFirst { get; set; }

        public string AuthorMiddle { get; set; }

        [Required]
        public string AuthorLast { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        [RegularExpression(@"\d{3}-? *\d{10}")]
        public string ISBN { get; set; }

        [Required]
        public string Class { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int NumPages { get; set; }
    }
}
