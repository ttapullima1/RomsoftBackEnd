using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_UBIGEOBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_UBIGEO;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class ADM_UBIGEOBL : Singleton<ADM_UBIGEOBL>, IADM_UBIGEOBL<ADM_UBIGEO>
    {
        public int Add(ADM_UBIGEO entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_UBIGEO entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_UBIGEO entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_UBIGEO> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_UBIGEO> GetAllActives()
        {
            return ADM_UBIGEORepository.Instancia.GetAllActives();
        }

        public IList<ADM_UBIGEO> GetAllFilters(ADM_UBIGEO entity)
        {
            return ADM_UBIGEORepository.Instancia.GetAllFilters(entity);
        }

        public IList<ADM_UBIGEO> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public ADM_UBIGEO GetByEstado(string rolNombre)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_UBIGEO> GetById(ADM_UBIGEO entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_UBIGEO entity)
        {
            throw new NotImplementedException();
        }
    }
}
