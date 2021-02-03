using Romsoft.GESTIONCLINICA.Business.Logic.Core;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.ICVN_PRODUCTO_PLANBL
{
    public interface ICVN_PRODUCTO_PLANBL<T> : ILogic<T> where T : class
    {
        bool Exists(T entity);
        IList<T> GetAllActivesFilters(T entity);
    }
}
