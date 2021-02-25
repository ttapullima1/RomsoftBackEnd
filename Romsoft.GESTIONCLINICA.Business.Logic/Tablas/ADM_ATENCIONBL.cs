using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_ATENCIONBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_ATENCION;
using System;
using System.Collections.Generic;
namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class ADM_ATENCIONBL : Singleton<ADM_ATENCIONBL>, IADM_ATENCIONBL<ADM_ATENCION>
    {
        public int Add(ADM_ATENCION entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_ATENCION entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_ATENCION entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ATENCION> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ATENCION> GetAllActives()
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ATENCION> GetAllFilters(ADM_ATENCION entity)
        {
            return ADM_ATENCIONRepository.Instancia.GetAllFilters(entity);
        }

        public IList<ADM_ATENCION> GetAllPaciente(int idPaciente)
        {
            return ADM_ATENCIONRepository.Instancia.GetAllPaciente(idPaciente);
        }

        public IList<ADM_ATENCION> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ATENCION> GetById(ADM_ATENCION entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_ATENCION entity)
        {
            throw new NotImplementedException();
        }
    }
}
