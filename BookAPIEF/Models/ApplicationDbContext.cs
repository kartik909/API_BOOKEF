using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookAPIEF.Models
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
     }
}