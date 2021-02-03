using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.ICVN_PRODUCTO_PLANBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.CVN_PRODUCTO_PLAN;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class CVN_PRODUCTO_PLANBL : Singleton<CVN_PRODUCTO_PLANBL>, ICVN_PRODUCTO_PLANBL<CVN_PRODUCTO_PLAN>
    {
        public int Add(CVN_PRODUCTO_PLAN entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(CVN_PRODUCTO_PLAN entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(CVN_PRODUCTO_PLAN entity)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_PRODUCTO_PLAN> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_PRODUCTO_PLAN> GetAllActives()
        {
            throw new NotImplementedException();
        }

        public IList<CVN_PRODUCTO_PLAN> GetAllActivesFilters(CVN_PRODUCTO_PLAN entity)
        {
            return CVN_PRODUCTO_PLANRepository.Instancia.GetAllActivesFilters(entity);
        }

        public IList<CVN_PRODUCTO_PLAN> GetAllFilters(CVN_PRODUCTO_PLAN entity)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_PRODUCTO_PLAN> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_PRODUCTO_PLAN> GetById(CVN_PRODUCTO_PLAN entity)
        {
            throw new NotImplementedException();
        }

        public int Update(CVN_PRODUCTO_PLAN entity)
        {
            throw new NotImplementedException();
        }
    }
}
