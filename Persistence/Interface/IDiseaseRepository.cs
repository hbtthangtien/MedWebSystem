using Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Interface
{
    public interface IDiseaseRepository : IGenericRepository<Disease>
    {
        public Task<IQueryable<Disease>> GetAll();
    }
}
