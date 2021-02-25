using Romsoft.GESTIONCLINICA.DataAccess.Core;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_ATENCIONRepository
{
    public interface IADM_ATENCIONRepository<T> : IRepository<T> where T : class
    {
        bool Exists(T entity);
        IList<T> GetAllPaciente(int idPaciente);
    }

}
