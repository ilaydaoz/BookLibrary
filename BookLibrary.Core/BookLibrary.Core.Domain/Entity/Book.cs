using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core.Domain.Entity
{
    public class Book : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public float Price { get; set; } = 0;
        public bool Ordered { get; set; } = false;
        public Guid? CategoryId { get; set; }
        public BookCategory Category { get; set; } = new BookCategory();
    }
}
