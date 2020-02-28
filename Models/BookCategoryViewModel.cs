using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Mvc_Core_Book_Application.Models
{
    public class BookCategoryViewModel
    {

        public List<Book> Books { get; set; }
        public SelectList Categories { get; set; }
        public string BookCategory { get; set; }
        public string Searchstr { get; set; }
    }
}
