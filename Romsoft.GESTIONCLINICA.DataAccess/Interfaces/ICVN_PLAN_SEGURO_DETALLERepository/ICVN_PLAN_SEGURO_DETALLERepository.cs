using Romsoft.GESTIONCLINICA.DataAccess.Core;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.ICVN_PLAN_SEGURO_DETALLERepository
{
    public interface ICVN_PLAN_SEGURO_DETALLERepository<T> : IRepository<T> where T : class
    {
        bool Exists(T entity);
        IList<T> GetAllActivesFilters(T entity);
    }
}
