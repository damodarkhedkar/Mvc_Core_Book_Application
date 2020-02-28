using Mvc_Core_Book_Application.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Mvc_Core_Book_Application.Models
{
    public class Seed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookContext(serviceProvider.GetRequiredService<DbContextOptions<BookContext>>()))
            {
                if(context.Books.Any())
                {
                    return;
                }

                context.Books.AddRange(
                    new Book { Btitle = "Indian Short Stories", Category = "Fiction", Price = 716.30, Author = "Narayan", Publisher = "Pengwin", ReleaseDate = Convert.ToDateTime("10-09-2014") }
                    
                    );
            }
        }
    }
}
