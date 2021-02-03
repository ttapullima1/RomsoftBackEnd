using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.ICVN_BENEFICIOBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.CVN_BENEFICIO;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class CVN_BENEFICIOBL : Singleton<CVN_BENEFICIOBL>, ICVN_BENEFICIOBL<CVN_BENEFICIO>
    {
        public int Add(CVN_BENEFICIO entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(CVN_BENEFICIO entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(CVN_BENEFICIO entity)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_BENEFICIO> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_BENEFICIO> GetAllActives()
        {
            return CVN_BENEFICIORepository.Instancia.GetAllActives();
        }

        public IList<CVN_BENEFICIO> GetAllFilters(CVN_BENEFICIO entity)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_BENEFICIO> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public CVN_BENEFICIO GetByEstado(string rolNombre)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_BENEFICIO> GetById(CVN_BENEFICIO entity)
        {
            throw new NotImplementedException();
        }

        public int Update(CVN_BENEFICIO entity)
        {
            throw new NotImplementedException();
        }
    }
}
