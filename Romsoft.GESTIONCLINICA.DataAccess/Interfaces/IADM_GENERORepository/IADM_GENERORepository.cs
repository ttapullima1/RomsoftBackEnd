using Romsoft.GESTIONCLINICA.DataAccess.Core;

namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_GENERORepository
{
    public interface IADM_GENERORepository<T> : IRepository<T>
 where T : class
    {
        bool Exists(T entity);
    }
}
