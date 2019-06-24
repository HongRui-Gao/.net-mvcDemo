using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacDemo.Model
{
    public class Books:BaseEntity
    {
        [Required]
        [StringLength(255)]
        [Column(TypeName = "varchar")]
        public string Books_Title { get; set; }

        [Required]
        [StringLength(255)]
        [Column(TypeName = "varchar")]
        public string Books_Author { get; set; }

        [Required]
        [StringLength(255)]
        [Column(TypeName = "varchar")]
        public string Books_Press { get; set; }

        [Required]
        public decimal Books_Price { get; set; }

        public int Books_Counts { get; set; }
        [ForeignKey(nameof(BooksCategory))]
        public Guid Books_Bcid { get; set; }

        public BooksCategory BooksCategory { get; set; }
    }
}
