﻿using BookLibrary.Core.Application.Cqrs.Commands.Response.Book;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core.Application.RequestManager.Book.Commands
{
    public class InsertBookRequestModel  :IRequest<InsertBookResponse>
    {
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public float Price { get; set; } = 0;
        public bool Ordered { get; set; } = false;
        public Guid CategoryId { get; set; }
    }
}
