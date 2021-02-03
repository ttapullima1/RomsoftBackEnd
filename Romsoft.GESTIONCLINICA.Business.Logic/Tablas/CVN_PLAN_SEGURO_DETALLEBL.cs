using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.ICVN_PLAN_SEGURO_DETALLEBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.CVN_PLAN_SEGURO_DETALLE;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class CVN_PLAN_SEGURO_DETALLEBL : Singleton<CVN_PLAN_SEGURO_DETALLEBL>, ICVN_PLAN_SEGURO_DETALLEBL<CVN_PLAN_SEGURO_DETALLE>
    {
        public int Add(CVN_PLAN_SEGURO_DETALLE entity)
        {
            return CVN_PLAN_SEGURO_DETALLERepository.Instancia.Add(entity);
        }

        public int Delete(CVN_PLAN_SEGURO_DETALLE entity)
        {
            return CVN_PLAN_SEGURO_DETALLERepository.Instancia.Delete(entity);
        }

        public bool Exists(CVN_PLAN_SEGURO_DETALLE entity)
        {
            return false;
        }

        public IList<CVN_PLAN_SEGURO_DETALLE> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_PLAN_SEGURO_DETALLE> GetAllActives()
        {
            throw new NotImplementedException();
        }

        public IList<CVN_PLAN_SEGURO_DETALLE> GetAllActivesFilters(CVN_PLAN_SEGURO_DETALLE entity)
        {
            return CVN_PLAN_SEGURO_DETALLERepository.Instancia.GetAllActivesFilters(entity);
        }

        public IList<CVN_PLAN_SEGURO_DETALLE> GetAllFilters(CVN_PLAN_SEGURO_DETALLE entity)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_PLAN_SEGURO_DETALLE> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_PLAN_SEGURO_DETALLE> GetById(CVN_PLAN_SEGURO_DETALLE entity)
        {
            throw new NotImplementedException();
        }

        public int Update(CVN_PLAN_SEGURO_DETALLE entity)
        {
            throw new NotImplementedException();
        }
    }
}
