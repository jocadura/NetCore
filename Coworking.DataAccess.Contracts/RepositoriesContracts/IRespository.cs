using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.DataAccess.Repositories
{
    public interface IRespository<T> where T:class
    {
        Task<bool> Exist(Guid id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(Guid id);
        Task DeleteAsync(Guid id);
        Task<T> Update(Guid id, T element);
        Task<T> Add(T element);
    }
}
