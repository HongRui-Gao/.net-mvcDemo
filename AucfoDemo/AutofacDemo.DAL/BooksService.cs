using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutofacDemo.IDAL;
using AutofacDemo.Model;

namespace AutofacDemo.DAL
{
    public class BooksService:BaseService<Books>,IBooksService
    {
        public BooksService() : base(new BooksDb())
        {
        }
    }
}
