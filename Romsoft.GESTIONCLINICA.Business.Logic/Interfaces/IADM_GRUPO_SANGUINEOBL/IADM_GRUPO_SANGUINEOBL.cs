using Romsoft.GESTIONCLINICA.Business.Logic.Core;
using System.Collections.Generic;
namespace Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_GRUPO_SANGUINEOBL
{

    public interface IADM_GRUPO_SANGUINEOBL<T> : ILogic<T> where T : class
    {
        bool Exists(T entity);
        T GetByEstado(string rolNombre);

        IList<T> GetAllActives();
    }
}
