using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacDemo.Model
{
    public class BooksCategory:BaseEntity
    {
        [Required]
        [StringLength(255),Column(TypeName = "varchar")]
        public string BooksCategory_Title { get; set; }
    }
}
