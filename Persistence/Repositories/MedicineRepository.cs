using Persistence.Entities;
using Persistence.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class MedicineRepository : IMedicineRepository
    {
        public Task AddAsync(Medicine entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Medicine entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Medicine>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Medicine?> GetBySingleAsync(Expression<Func<Medicine, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangeAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Medicine entity)
        {
            throw new NotImplementedException();
        }
    }
}
