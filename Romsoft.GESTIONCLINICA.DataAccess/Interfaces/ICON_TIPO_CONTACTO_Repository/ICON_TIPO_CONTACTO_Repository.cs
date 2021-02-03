using Romsoft.GESTIONCLINICA.DataAccess.Core;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.ICON_TIPO_CONTACTO_Repository
{

    public interface ICON_TIPO_CONTACTORepository<T> : IRepository<T>
       where T : class
    {
        bool Exists(T entity);
        T GetByEstado(string estadoNombre);
        IList<T> GetAllActives();

    }
}
