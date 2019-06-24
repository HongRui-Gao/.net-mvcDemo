using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutofacDemo.Model;
using AutofacDemo.IDAL;
namespace AutofacDemo.DAL
{
    public class BooksCategoryService : BaseService<BooksCategory>,IBookCategoryService
    {
        public BooksCategoryService() : base(new BooksDb())
        {
        }
    }
}
