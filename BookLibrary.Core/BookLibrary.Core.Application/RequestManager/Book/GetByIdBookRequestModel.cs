﻿using BookLibrary.Core.Application.Queries.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core.Application.RequestManager.Book
{
    public class GetByIdBookRequestModel : IRequest<BookGetbyIdResponse>
    {
        public Guid Id { get; set; }
    }
}