using Romsoft.GESTIONCLINICA.DataAccess.Core;


namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_DOCUMENTO_IDENTIDADRepository
{
    public interface IADM_DOCUMENTO_IDENTIDADRepository<T> : IRepository<T>
  where T : class
    {
        bool Exists(T entity);
    }
}
