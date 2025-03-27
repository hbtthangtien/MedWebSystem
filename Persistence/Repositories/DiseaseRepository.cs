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
    public class DiseaseRepository : IDiseaseRepository
    {
        public Task AddAsync(Disease entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Disease entity)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Disease>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Disease>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Disease?> GetBySingleAsync(Expression<Func<Disease, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangeAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Disease entity)
        {
            throw new NotImplementedException();
        }
    }
}
