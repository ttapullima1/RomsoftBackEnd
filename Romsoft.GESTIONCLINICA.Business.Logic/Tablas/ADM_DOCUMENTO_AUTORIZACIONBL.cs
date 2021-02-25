using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.IADM_DOCUMENTO_AUTORIZACIONBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_DOCUMENTO_AUTORIZACION;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class ADM_DOCUMENTO_AUTORIZACIONBL : Singleton<ADM_DOCUMENTO_AUTORIZACIONBL>, IADM_DOCUMENTO_AUTORIZACIONBL<ADM_DOCUMENTO_AUTORIZACION>
    {
        public int Add(ADM_DOCUMENTO_AUTORIZACION entity)
        {
            return ADM_DOCUMENTO_AUTORIZACIONRepository.Instancia.Add(entity);
        }

        public int Delete(ADM_DOCUMENTO_AUTORIZACION entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_DOCUMENTO_AUTORIZACION entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_AUTORIZACION> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_AUTORIZACION> GetAllActives()
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_AUTORIZACION> GetAllFilters(ADM_DOCUMENTO_AUTORIZACION entity)
        {
            return ADM_DOCUMENTO_AUTORIZACIONRepository.Instancia.GetAllFilters(entity);
        }

        public IList<ADM_DOCUMENTO_AUTORIZACION> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public ADM_DOCUMENTO_AUTORIZACION GetByEstado(string rolNombre)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_AUTORIZACION> GetById(ADM_DOCUMENTO_AUTORIZACION entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_DOCUMENTO_AUTORIZACION entity)
        {
            throw new NotImplementedException();
        }
    }
}
