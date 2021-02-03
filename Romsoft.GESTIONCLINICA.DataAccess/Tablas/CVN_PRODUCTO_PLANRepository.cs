using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.ICVN_PRODUCTO_PLANRepository;
using Romsoft.GESTIONCLINICA.Entidades.CVN_PRODUCTO_PLAN;
using System;
using System.Collections.Generic;
using System.Data;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class CVN_PRODUCTO_PLANRepository : Singleton<CVN_PRODUCTO_PLANRepository>, ICVN_PRODUCTO_PLANRepository<CVN_PRODUCTO_PLAN>
    {
        #region Attributos

        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);


        #endregion

        public int Add(CVN_PRODUCTO_PLAN entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(CVN_PRODUCTO_PLAN entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(CVN_PRODUCTO_PLAN entity)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_PRODUCTO_PLAN> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_PRODUCTO_PLAN> GetAllActives()
        {
            throw new NotImplementedException();
        }

        public IList<CVN_PRODUCTO_PLAN> GetAllActivesFilters(CVN_PRODUCTO_PLAN entity)
        {
            List<CVN_PRODUCTO_PLAN> producto_plan = new List<CVN_PRODUCTO_PLAN>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_CVN_PRODUCTO_PLAN_GetAllActives")))
            {
                _database.AddInParameter(comando, "@c_codigo_iafa", DbType.Int32, entity.c_codigo_iafa);

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        producto_plan.Add(new CVN_PRODUCTO_PLAN
                        {

                            id_producto_plan = lector.IsDBNull(lector.GetOrdinal("id_producto_plan")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_producto_plan")),
                            c_codigo = lector.IsDBNull(lector.GetOrdinal("c_codigo")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),

                        });
                    }
                }
            }

            return producto_plan;
        }

        public IList<CVN_PRODUCTO_PLAN> GetAllFilters(CVN_PRODUCTO_PLAN entity)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_PRODUCTO_PLAN> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_PRODUCTO_PLAN> GetById(CVN_PRODUCTO_PLAN entity)
        {
            throw new NotImplementedException();
        }

        public int Update(CVN_PRODUCTO_PLAN entity)
        {
            throw new NotImplementedException();
        }
    }
}
