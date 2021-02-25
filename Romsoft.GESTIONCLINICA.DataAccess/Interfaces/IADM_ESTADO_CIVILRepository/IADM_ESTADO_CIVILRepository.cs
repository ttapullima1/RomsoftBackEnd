using Romsoft.GESTIONCLINICA.DataAccess.Core;


namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_ESTADO_CIVILRepository
{

    public interface IADM_ESTADO_CIVILRepository<T> : IRepository<T>
  where T : class
    {
        bool Exists(T entity);
    }
}
