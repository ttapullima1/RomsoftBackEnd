using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_ESTADO_CIVILBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_ESTADO_CIVIL;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class ADM_ESTADO_CIVILBL : Singleton<ADM_ESTADO_CIVILBL>, IADM_ESTADO_CIVILBL<ADM_ESTADO_CIVIL>
    {
        public int Add(ADM_ESTADO_CIVIL entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_ESTADO_CIVIL entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_ESTADO_CIVIL entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ESTADO_CIVIL> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ESTADO_CIVIL> GetAllActives()
        {
            return ADM_ESTADO_CIVILRepository.Instancia.GetAllActives();
        }

        public IList<ADM_ESTADO_CIVIL> GetAllFilters(ADM_ESTADO_CIVIL entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ESTADO_CIVIL> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public ADM_ESTADO_CIVIL GetByEstado(string rolNombre)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ESTADO_CIVIL> GetById(ADM_ESTADO_CIVIL entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_ESTADO_CIVIL entity)
        {
            throw new NotImplementedException();
        }
    }
}
