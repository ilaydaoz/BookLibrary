using AutoMapper;
using BookLibrary.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core.Application.Services.Queries.Book.GetAll
{
    public class BookGetAllQueryMapper : Profile
    {
        public BookGetAllQueryMapper()
        {
           CreateMap<Domain.Entity.Book, BookGetAllQueryResponse>(); 
        }
    }
}
