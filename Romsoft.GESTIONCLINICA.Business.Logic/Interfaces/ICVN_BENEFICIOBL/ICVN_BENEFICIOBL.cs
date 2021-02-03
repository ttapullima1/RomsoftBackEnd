using Romsoft.GESTIONCLINICA.Business.Logic.Core;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.ICVN_BENEFICIOBL
{
    public interface ICVN_BENEFICIOBL<T> : ILogic<T> where T : class
    {
        bool Exists(T entity);
        T GetByEstado(string rolNombre);

        IList<T> GetAllActives();
    }
}
