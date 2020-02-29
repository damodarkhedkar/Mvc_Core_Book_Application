using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_Core_Book_Application.Models
{
    public class BookPublisherViewModelcs
    {
        public List<Book> Books { get; set; }
        public SelectList Publisher { get; set; }
        public string BookPublisher { get; set; }
        public string Searchstr { get; set; }
    }
}
