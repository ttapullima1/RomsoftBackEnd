using Romsoft.GESTIONCLINICA.DataAccess.Core;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.ICVN_PRODUCTO_PLANRepository
{
    public interface ICVN_PRODUCTO_PLANRepository<T> : IRepository<T> where T : class
    {
        bool Exists(T entity);
        IList<T> GetAllActivesFilters(T entity);
    }
}
