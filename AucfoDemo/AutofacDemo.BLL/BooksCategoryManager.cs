using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutofacDemo.DAL;
using AutofacDemo.Dto;
using AutofacDemo.IBLL;
using AutofacDemo.IDAL;
using System.Data.Entity;
using AutofacDemo.Model;

namespace AutofacDemo.BLL
{
    public class BooksCategoryManager:IBooksCategoryManager
    {
        private readonly IBookCategoryService _bookscategorySvc;

        public BooksCategoryManager()
        {
            _bookscategorySvc = new BooksCategoryService();
        }
        public async Task<List<BooksCategoryDto>> GetData()
        {
            return await _bookscategorySvc.GetAll().Select(t => new BooksCategoryDto()
            {
                Id = t.Id,
                BooksCategory_Title = t.BooksCategory_Title

            }).ToListAsync();

        }
        

        public async Task CreateBooksCategoryAsync(string name)
        {
           await _bookscategorySvc.CreateAsync(new BooksCategory() {BooksCategory_Title = name});
        }
    }
}
