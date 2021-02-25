using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_GENEROBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_GENERO;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class ADM_GENEROBL : Singleton<ADM_GENEROBL>, IADM_GENEROBL<ADM_GENERO>
    {
        public int Add(ADM_GENERO entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_GENERO entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_GENERO entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_GENERO> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_GENERO> GetAllActives()
        {
            return ADM_GENERORepository.Instancia.GetAllActives();
        }

        public IList<ADM_GENERO> GetAllFilters(ADM_GENERO entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_GENERO> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public ADM_GENERO GetByEstado(string rolNombre)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_GENERO> GetById(ADM_GENERO entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_GENERO entity)
        {
            throw new NotImplementedException();
        }
    }
}
