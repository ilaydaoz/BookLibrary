using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core.Application.Services.Commands.Book.Insert
{
    public class BookInsertCommandMapper : Profile       
    {
        public BookInsertCommandMapper ()
        {
           CreateMap<Domain.Entity.Book, BookInsertCommandResponse>();   
        }
    }
}
