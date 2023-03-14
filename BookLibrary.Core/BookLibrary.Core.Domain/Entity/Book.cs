using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core.Domain.Entity
{
   // [Table("Book", Schema = "Entity")]
    public class Book : BaseEntity
    {
        public string Title { get; set; } 
        public string Author { get; set; } 
        public float Price { get; set; } 
        public bool Ordered { get; set; } = false;
        public Guid? CategoryId { get; set; }
        public BookCategory Category { get; set; } = new BookCategory();
    }
}
