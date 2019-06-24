using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AucfoDemo.WebUI.Models.BooksCategory
{
    public class BooksCategoryViewModel
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(255),Column(TypeName = "varchar")]
        public string BooksCategory_Title { get; set; }
    }
}