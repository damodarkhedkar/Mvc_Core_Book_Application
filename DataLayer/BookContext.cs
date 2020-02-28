using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;     //Needed for DBContext
using Mvc_Core_Book_Application.Models;  //Needed for Model CLass

namespace Mvc_Core_Book_Application.DataLayer
{
    public class BookContext:DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        { 
        
        }

        public DbSet<Book> Books { get; set; }
    }
}
