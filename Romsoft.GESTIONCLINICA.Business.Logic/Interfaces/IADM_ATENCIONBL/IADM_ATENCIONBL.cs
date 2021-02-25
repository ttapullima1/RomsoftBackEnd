using Romsoft.GESTIONCLINICA.Business.Logic.Core;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_ATENCIONBL
{
    public interface IADM_ATENCIONBL<T> : ILogic<T> where T : class
    {
        bool Exists(T entity);
        IList<T> GetAllPaciente(int idPaciente);
    }
}
