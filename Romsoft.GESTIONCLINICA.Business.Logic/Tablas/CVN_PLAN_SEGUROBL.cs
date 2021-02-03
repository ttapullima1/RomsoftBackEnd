using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.ICVN_PLAN_SEGUROBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.CVN_PLAN_SEGURO;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class CVN_PLAN_SEGUROBL : Singleton<CVN_PLAN_SEGUROBL>, ICVN_PLAN_SEGUROBL<CVN_PLAN_SEGURO>
    {
        public int Add(CVN_PLAN_SEGURO entity)
        {
            return CVN_PLAN_SEGURORepository.Instancia.Add(entity);
        }

        public int Delete(CVN_PLAN_SEGURO entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(CVN_PLAN_SEGURO entity)
        {
            return false;
        }

        public IList<CVN_PLAN_SEGURO> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_PLAN_SEGURO> GetAllActives()
        {
            return CVN_PLAN_SEGURORepository.Instancia.GetAllActives();
        }

        public IList<CVN_PLAN_SEGURO> GetAllFilters(CVN_PLAN_SEGURO entity)
        {
            return CVN_PLAN_SEGURORepository.Instancia.GetAllFilters(entity);
        }

        public IList<CVN_PLAN_SEGURO> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_PLAN_SEGURO> GetById(CVN_PLAN_SEGURO entity)
        {
            return CVN_PLAN_SEGURORepository.Instancia.GetById(entity);
        }

        public int Update(CVN_PLAN_SEGURO entity)
        {
            return CVN_PLAN_SEGURORepository.Instancia.Update(entity);
        }
    }
}
