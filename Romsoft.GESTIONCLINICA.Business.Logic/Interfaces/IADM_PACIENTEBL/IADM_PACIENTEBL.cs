using Romsoft.GESTIONCLINICA.Business.Logic.Core;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_PACIENTEBL
{

    public interface IADM_PACIENTEBL<T> : ILogic<T> where T : class
    {
        bool Exists(T entity);

    }

}
