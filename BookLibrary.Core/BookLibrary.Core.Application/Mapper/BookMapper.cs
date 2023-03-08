using AutoMapper;
using BookLibrary.Core.Application.Cqrs.Queries.Response.Book;
using BookLibrary.Core.Application.RequestManager.Book.Commands;
using BookLibrary.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core.Application.Mapper
{
    public class BookMapper : Profile
    {
        public BookMapper ()
        {
          CreateMap<UpdateBookRequestModel, Book>();      
          CreateMap<Book, GetAllBookResponse>();        
        }
    }
}
