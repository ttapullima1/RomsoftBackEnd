using Romsoft.GESTIONCLINICA.Business.Logic.Core;
using System.Collections.Generic;


namespace Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.ICVN_PLAN_SEGURO_DETALLEBL
{
    public interface ICVN_PLAN_SEGURO_DETALLEBL<T> : ILogic<T> where T : class
    {
        bool Exists(T entity);

        IList<T> GetAllActivesFilters(T entity);
    }
}
