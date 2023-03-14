using BookLibrary.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core.Application.Services.Commands.Book.Insert
{
    public class BookInsertCommandResponse 
    {
        public string Title { get; set; } 
        public string Author { get; set; } 
        public float Price { get; set; }
        public bool Ordered { get; set; } 
        public Guid? CategoryId { get; set; }
    }
}
