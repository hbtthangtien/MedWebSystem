using Persistence.Config;
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
    public class SymtompRepository : ISymtompsesRespository
    {
        private readonly MedSystemContext _medSystemContext;
        public SymtompRepository(MedSystemContext medSystemContext)
        {
            _medSystemContext = medSystemContext;
        }
        public Task AddAsync(Symptoms entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Symptoms entity)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Symptoms>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Symptoms>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Symptoms?> GetBySingleAsync(Expression<Func<Symptoms, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangeAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Symptoms entity)
        {
            throw new NotImplementedException();
        }
    }
}
