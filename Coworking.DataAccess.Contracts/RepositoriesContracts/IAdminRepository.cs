using Coworking.DataAccess.Contracts.EntitiesBBDD;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.DataAccess.Repositories
{
    public interface IAdminRepository : IRespository<AdminEntity>
    {
        Task<bool> Exist(Guid id);
        Task<IEnumerable<AdminEntity>> GetAll();
        Task<AdminEntity> Get(Guid id);
        Task DeleteAsync(Guid id);
        Task<AdminEntity> Update(Guid id, AdminEntity element);
        Task<AdminEntity> Add(AdminEntity element);
    }
}
