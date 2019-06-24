using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacDemo.Model
{
    public class BooksDb:DbContext
    {
        public BooksDb()
        :base("name=DbCon")
        {
                
        }

        public DbSet<BooksCategory> BooksCategories { get; set; }

        public DbSet<Books> Books { get; set; }

       
    }
}
