using Romsoft.GESTIONCLINICA.DataAccess.Core;

namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_PACIENTERepository
{

    public interface IADM_PACIENTERepository<T> : IRepository<T> where T : class
    {
        bool Exists(T entity);
    }
}
