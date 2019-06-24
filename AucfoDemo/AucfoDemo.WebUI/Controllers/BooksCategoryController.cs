using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AucfoDemo.WebUI.Models.BooksCategory;
using AutofacDemo.IBLL;
namespace AucfoDemo.WebUI.Controllers
{
    public class BooksCategoryController : Controller
    {
        private readonly IBooksCategoryManager booksCategory;

        public BooksCategoryController(IBooksCategoryManager booksCategory)
        {
            this.booksCategory = booksCategory;
        }
        // GET: BooksCategory
        public async Task<ActionResult> Index()
        {
            var list = await  booksCategory.GetData();
            return View(list);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(BooksCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                booksCategory.CreateBooksCategoryAsync(model.BooksCategory_Title);
                return RedirectToAction("Index");
            }

            return View();

        }



    }
}