using Romsoft.GESTIONCLINICA.DataAccess.Core;

namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.ICVN_TARIFARIO_SEGUSRepository
{
    public interface ICVN_TARIFARIO_SEGUSRepository<T> : IRepository<T> where T : class
    {
        bool Exists(T entity);
    }
}
