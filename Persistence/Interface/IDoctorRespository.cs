using Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Interface
{
    public interface IDoctorRespository : IGenericRepository<Doctor>
    {
        public Task<IQueryable<Doctor>> GetByName(Expression<Func<Doctor, List<Doctor>>> predicate);
    }
}
