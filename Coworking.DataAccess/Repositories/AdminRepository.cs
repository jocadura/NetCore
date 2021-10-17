using Coworking.DataAccess.Contracts;
using Coworking.DataAccess.Contracts.EntitiesBBDD;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.DataAccess.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly ICoworkingDBContext _coworkingDBContext;

        public AdminRepository(ICoworkingDBContext dBContext)
        {
            _coworkingDBContext = dBContext;
        }

        public Task<bool> Exist(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AdminEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<AdminEntity> Get(Guid id)
        {
            var result = await _coworkingDBContext.Admins.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<AdminEntity> Update(AdminEntity entity)
        {
            var updateEntity = _coworkingDBContext.Admins.Update(entity);
            await _coworkingDBContext.SaveChangesAsync();
            return updateEntity.Entity;
        }

        public async Task<AdminEntity> Add(AdminEntity entity)
        {
            await _coworkingDBContext.Admins.AddAsync(entity);
            await _coworkingDBContext.SaveChangesAsync();
            return entity;
        }

        public Task<AdminEntity> Update(Guid id, AdminEntity element)
        {
            throw new NotImplementedException();
        }

        public int loquesea(AdminEntity elem)
        {
            _coworkingDBContext.Admins.Add(elem);
            return _coworkingDBContext.SaveChanges();
        }
    }
}
