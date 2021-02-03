using Romsoft.GESTIONCLINICA.Business.Logic.Core;
namespace Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.ICVN_PLAN_SEGUROBL
{
    public interface ICVN_PLAN_SEGUROBL<T> : ILogic<T> where T : class
    {
        bool Exists(T entity);
    }
}
