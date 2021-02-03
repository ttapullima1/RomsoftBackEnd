using Romsoft.GESTIONCLINICA.Business.Logic.Interfaces.ICON_TIPO_CONTACTOBL;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.CON_TIPO_CONTACTO;
using System;
using System.Collections.Generic;

namespace Romsoft.GESTIONCLINICA.Business.Logic.Tablas
{
    
    public class CON_TIPO_CONTACTOBL : Singleton<CON_TIPO_CONTACTOBL>, ICON_TIPO_TIPO_CONTACTOBL<CON_TIPO_CONTACTO>
    {
        public int Add(CON_TIPO_CONTACTO entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(CON_TIPO_CONTACTO entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(CON_TIPO_CONTACTO entity)
        {
            throw new NotImplementedException();
        }

        public IList<CON_TIPO_CONTACTO> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<CON_TIPO_CONTACTO> GetAllActives()
        {
            return CON_TIPO_CONTACTORepository.Instancia.GetAllActives();
            
        }

        public IList<CON_TIPO_CONTACTO> GetAllFilters(CON_TIPO_CONTACTO entity)
        {
            throw new NotImplementedException();
        }

        public IList<CON_TIPO_CONTACTO> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public CON_TIPO_CONTACTO GetByEstado(string rolNombre)
        {
            throw new NotImplementedException();
        }

        public IList<CON_TIPO_CONTACTO> GetById(CON_TIPO_CONTACTO entity)
        {
            throw new NotImplementedException();
        }

        public int Update(CON_TIPO_CONTACTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
