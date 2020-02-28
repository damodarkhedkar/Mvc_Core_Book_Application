using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mvc_Core_Book_Application.Models
{
    public class Book
    {             
       
        [Required]
        [Key]
        public int Bid { get; set; }
        [Required]
        [Display(Name ="Book Title")]
        public string Btitle { get; set; }
        [Required]
        public string Category { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; } 
        [Required]
        [Display(Name = "Author Name")]
        public string Author { get; set; }
        [Required]
        [Display(Name = "Publisher Name")]
        public string Publisher { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime ReleaseDate { get; set; }
    }
}
