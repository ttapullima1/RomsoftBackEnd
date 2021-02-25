using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_PACIENTEBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_PACIENTE;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class ADM_PACIENTEBL : Singleton<ADM_PACIENTEBL>, IADM_PACIENTEBL<ADM_PACIENTE>
    {
        public int Add(ADM_PACIENTE entity)
        {
            return ADM_PACIENTERepository.Instancia.Add(entity);
        }

        public int Delete(ADM_PACIENTE entity)
        {
            return ADM_PACIENTERepository.Instancia.Delete(entity);
        }

        public bool Exists(ADM_PACIENTE entity)
        {
            return ADM_PACIENTERepository.Instancia.Exists(entity);
        }

        public IList<ADM_PACIENTE> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_PACIENTE> GetAllActives()
        {
            throw new NotImplementedException();
        }

        public IList<ADM_PACIENTE> GetAllFilters(ADM_PACIENTE entity)
        {
            return ADM_PACIENTERepository.Instancia.GetAllFilters(entity);
        }

        public IList<ADM_PACIENTE> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_PACIENTE> GetById(ADM_PACIENTE entity)
        {
            return ADM_PACIENTERepository.Instancia.GetById(entity);
        }

        public int Update(ADM_PACIENTE entity)
        {
            return ADM_PACIENTERepository.Instancia.Update(entity);
        }
    }
}
