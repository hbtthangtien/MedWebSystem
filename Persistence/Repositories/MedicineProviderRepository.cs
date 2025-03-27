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
    public class MedicineProviderRepository : IMedicineProviderRepository
    {
        public Task AddAsync(MedicineProvider entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(MedicineProvider entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MedicineProvider>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MedicineProvider?> GetBySingleAsync(Expression<Func<MedicineProvider, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangeAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(MedicineProvider entity)
        {
            throw new NotImplementedException();
        }
    }
}
