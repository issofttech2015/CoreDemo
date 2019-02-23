using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreDemoService.IRepositories
{
    public interface IRepository<T> where T : class
    {
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<bool> Delete(T entity);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> AddRange(T entity);
        Task<T> UpdateRange(T entity);
    }
}
