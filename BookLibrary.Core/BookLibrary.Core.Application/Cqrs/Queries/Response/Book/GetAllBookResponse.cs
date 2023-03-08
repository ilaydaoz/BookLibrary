﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core.Application.Cqrs.Queries.Response.Book
{
    public class GetAllBookResponse
    {
        public Guid Id { get; set; }
        public Guid? CategoryId { get; set; }
    }
}