using Romsoft.GESTIONCLINICA.DataAccess.Core;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.ICVN_BENEFICIORepository
{
    public interface ICVN_BENEFICIORepository<T> : IRepository<T>
    where T : class
    {
        bool Exists(T entity);
        T GetByEstado(string estadoNombre);
        IList<T> GetAllActives();

    }
}
