using Romsoft.GESTIONCLINICA.DataAccess.Core;

namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.ICVN_PLAN_SEGURORepository
{

    public interface ICVN_PLAN_SEGURORepository<T> : IRepository<T> where T : class
    {
        bool Exists(T entity);
    }
}
