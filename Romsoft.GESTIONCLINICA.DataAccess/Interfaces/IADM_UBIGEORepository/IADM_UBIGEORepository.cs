using Romsoft.GESTIONCLINICA.DataAccess.Core;

namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_UBIGEORepository
{
    public interface IADM_UBIGEORepository<T> : IRepository<T>
   where T : class
    {
        bool Exists(T entity);
    }
}
