using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core.Domain.Entity
{
    public class Order : Baseentity
    {
        public Guid UserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public Guid BookId { get; set; }
        public string BookName { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public int Returned { get; set; }
    }
}
