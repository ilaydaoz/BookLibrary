using AutoMapper;
using BookLibrary.Core.Domain.Entity;
using BookLibrary.Core.RequestManager.Commands.Book;
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
          CreateMap<InsertBookRequestModel, Book>();
        }
    }
}
