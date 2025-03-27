using Persistence.Entities;
using System.Linq.Expressions;

namespace Persistence.Interface
{
    public interface ISymtompsesRespository : IGenericRepository<Symptoms>
    {
        public Task<IQueryable<Symptoms>> GetAll();
    }
}
