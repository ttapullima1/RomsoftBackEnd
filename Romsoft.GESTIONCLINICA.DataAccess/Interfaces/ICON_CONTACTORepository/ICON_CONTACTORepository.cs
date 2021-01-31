using Romsoft.GESTIONCLINICA.DataAccess.Core;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.ICON_CONTACTORepository
{

    public interface ICON_CONTACTORepository<T> : IRepository<T>
  where T : class
    {
        bool Exists(T entity);
        T GetByEstado(string estadoNombre);
        IList<T> GetAllActives();

    }
}
