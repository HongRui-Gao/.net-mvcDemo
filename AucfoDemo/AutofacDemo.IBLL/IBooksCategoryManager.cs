using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutofacDemo.Dto;
namespace AutofacDemo.IBLL
{
    public interface IBooksCategoryManager
    {
         Task<List<BooksCategoryDto>> GetData();

         Task CreateBooksCategoryAsync(string name);
    }
}
