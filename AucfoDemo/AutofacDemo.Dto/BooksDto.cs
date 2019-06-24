using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacDemo.Dto
{
    public class BooksDto
    {
        public Guid Id { get; set; }
        public string Books_Title { get; set; }
        public string Books_Author { get; set; }
        public string Books_Press { get; set; }
        public decimal Books_Price { get; set; }
        public int Books_Count { get; set; }
        public int Books_Bcid { get; set; }
    }
}
