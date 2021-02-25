using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_DOCUMENTO_IDENTIDADBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_DOCUMENTO_IDENTIDAD;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class ADM_DOCUMENTO_IDENTIDADBL : Singleton<ADM_DOCUMENTO_IDENTIDADBL>, IADM_DOCUMENTO_IDENTIDADBL<ADM_DOCUMENTO_IDENTIDAD>
    {
        public int Add(ADM_DOCUMENTO_IDENTIDAD entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_DOCUMENTO_IDENTIDAD entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_DOCUMENTO_IDENTIDAD entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_IDENTIDAD> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_IDENTIDAD> GetAllActives()
        {
            return ADM_DOCUMENTO_IDENTIDADRepository.Instancia.GetAllActives();
        }

        public IList<ADM_DOCUMENTO_IDENTIDAD> GetAllFilters(ADM_DOCUMENTO_IDENTIDAD entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_IDENTIDAD> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public ADM_DOCUMENTO_IDENTIDAD GetByEstado(string rolNombre)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_IDENTIDAD> GetById(ADM_DOCUMENTO_IDENTIDAD entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_DOCUMENTO_IDENTIDAD entity)
        {
            throw new NotImplementedException();
        }
    }
}
