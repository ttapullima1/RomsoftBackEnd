using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.ICON_CONTACTOBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.CON_CONTACTO;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    public class CON_CONTACTOBL : Singleton<CON_CONTACTOBL>, ICON_CONTACTOBL<CON_CONTACTO>
    {
        public int Add(CON_CONTACTO entity)
        {
            return CON_CONTACTORepository.Instancia.Add(entity);
        }

        public int Delete(CON_CONTACTO entity)
        {
            return CON_CONTACTORepository.Instancia.Delete(entity);
        }

        public bool Exists(CON_CONTACTO entity)
        {
            return CON_CONTACTORepository.Instancia.Exists(entity);
        }

        public IList<CON_CONTACTO> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<CON_CONTACTO> GetAllActives()
        {
            throw new NotImplementedException();
        }

        public IList<CON_CONTACTO> GetAllFilters(CON_CONTACTO entity)
        {
            return CON_CONTACTORepository.Instancia.GetAllFilters(entity);
        }

        public IList<CON_CONTACTO> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public CON_CONTACTO GetByEstado(string rolNombre)
        {
            throw new NotImplementedException();
        }

        public IList<CON_CONTACTO> GetById(CON_CONTACTO entity)
        {
            return CON_CONTACTORepository.Instancia.GetById(entity);
        }

        public int Update(CON_CONTACTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
