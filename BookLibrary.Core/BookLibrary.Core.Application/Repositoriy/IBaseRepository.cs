using BookLibrary.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core.Application.Repositoriy
{
    public interface IBaseRepository<T> where T : Baseentity
    {
        Task<bool> Add(T entity);
        Task<T> Update(T entity);
        bool Delete(T entity);
        Task<T> GetById(Guid id);
        Task<int> SaveAsync();
        Task<List<T>> GetAll();
    }
}
