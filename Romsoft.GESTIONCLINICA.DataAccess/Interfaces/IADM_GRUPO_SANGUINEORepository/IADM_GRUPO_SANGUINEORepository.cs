using Romsoft.GESTIONCLINICA.DataAccess.Core;

namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_GRUPO_SANGUINEORepository
{
    public interface IADM_GRUPO_SANGUINEORepository<T> : IRepository<T>
 where T : class
    {
        bool Exists(T entity);
    }
}
