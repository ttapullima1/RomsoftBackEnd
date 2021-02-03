using Romsoft.GESTIONCLINICA.Business.Logic.Core;
using System.Collections.Generic;


namespace Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.ICVN_MONEDABL
{
    public interface ICVN_MONEDABL<T> : ILogic<T> where T : class
    {
        bool Exists(T entity);
        T GetByEstado(string rolNombre);

        IList<T> GetAllActives();
    }
}
