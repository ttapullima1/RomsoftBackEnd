using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.ICON_TIPO_CONTACTO_Repository;
using Romsoft.GESTIONCLINICA.Entidades.CON_TIPO_CONTACTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class CON_TIPO_CONTACTORepository : Singleton<CON_TIPO_CONTACTORepository>, ICON_TIPO_CONTACTORepository<CON_TIPO_CONTACTO>
    {

        #region Attributos

        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);


        #endregion


        #region Métodos Públicos

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
            List<CON_TIPO_CONTACTO> estados = new List<CON_TIPO_CONTACTO>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_CON_TIPO_CONTACTO_GetAllActives")))
            {
                //_database.AddInParameter(comando, "@tabla", DbType.String, entity.tabla);
                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        estados.Add(new CON_TIPO_CONTACTO
                        {
                            id_tipo_contacto = lector.IsDBNull(lector.GetOrdinal("id_tipo_contacto")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipo_contacto")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),
                    });
                    }
                }
            }

            return estados;
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

        #endregion

    }
}
