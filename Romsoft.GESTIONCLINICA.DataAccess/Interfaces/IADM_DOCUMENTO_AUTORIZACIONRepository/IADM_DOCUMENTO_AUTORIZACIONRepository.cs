using Romsoft.GESTIONCLINICA.DataAccess.Core;
using System.Collections.Generic;


namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_DOCUMENTO_AUTORIZACIONRepository
{
    public interface IADM_DOCUMENTO_AUTORIZACIONRepository<T> : IRepository<T>
    where T : class
    {
        bool Exists(T entity);
        T GetByEstado(string estadoNombre);
        IList<T> GetAllActives();

    }
}
