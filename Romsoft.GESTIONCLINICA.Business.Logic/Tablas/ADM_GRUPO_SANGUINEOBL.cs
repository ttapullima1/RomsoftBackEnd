using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_GRUPO_SANGUINEOBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_GRUPO_SANGUINEO;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class ADM_GRUPO_SANGUINEOBL : Singleton<ADM_GRUPO_SANGUINEOBL>, IADM_GRUPO_SANGUINEOBL<ADM_GRUPO_SANGUINEO>
    {
        public int Add(ADM_GRUPO_SANGUINEO entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_GRUPO_SANGUINEO entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_GRUPO_SANGUINEO entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_GRUPO_SANGUINEO> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_GRUPO_SANGUINEO> GetAllActives()
        {
            return ADM_GRUPO_SANGUINEORepository.Instancia.GetAllActives();
        }

        public IList<ADM_GRUPO_SANGUINEO> GetAllFilters(ADM_GRUPO_SANGUINEO entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_GRUPO_SANGUINEO> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public ADM_GRUPO_SANGUINEO GetByEstado(string rolNombre)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_GRUPO_SANGUINEO> GetById(ADM_GRUPO_SANGUINEO entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_GRUPO_SANGUINEO entity)
        {
            throw new NotImplementedException();
        }
    }
}
