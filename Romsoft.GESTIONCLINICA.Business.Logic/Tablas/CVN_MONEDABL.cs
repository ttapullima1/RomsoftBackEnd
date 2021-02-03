using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.ICVN_MONEDABL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.CVN_MONEDA;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class CVN_MONEDABL : Singleton<CVN_MONEDABL>, ICVN_MONEDABL<CVN_MONEDA>
    {
        public int Add(CVN_MONEDA entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(CVN_MONEDA entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(CVN_MONEDA entity)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_MONEDA> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_MONEDA> GetAllActives()
        {
            return CVN_MONEDARepository.Instancia.GetAllActives();
        }

        public IList<CVN_MONEDA> GetAllFilters(CVN_MONEDA entity)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_MONEDA> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public CVN_MONEDA GetByEstado(string rolNombre)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_MONEDA> GetById(CVN_MONEDA entity)
        {
            throw new NotImplementedException();
        }

        public int Update(CVN_MONEDA entity)
        {
            throw new NotImplementedException();
        }
    }
}
