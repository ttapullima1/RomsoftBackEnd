using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.ICVN_MONEDARepository;
using Romsoft.GESTIONCLINICA.Entidades.CVN_MONEDA;
using System;
using System.Collections.Generic;
using System.Data;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class CVN_MONEDARepository : Singleton<CVN_MONEDARepository>, ICVN_MONEDARepository<CVN_MONEDA>
    {
        #region Attributos

        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);

        #endregion

        public int Add(CVN_MONEDA entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(CVN_MONEDA entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(CVN_MONEDA entity)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_MONEDA> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_MONEDA> GetAllActives()
        {
            List<CVN_MONEDA> moneda = new List<CVN_MONEDA>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_CVN_MONEDA_GetAllActives")))
            {
                //_database.AddInParameter(comando, "@f_estado", DbType.Int32, entity.f_estado);

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        moneda.Add(new CVN_MONEDA
                        {
                            id_moneda = lector.IsDBNull(lector.GetOrdinal("id_moneda")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_moneda")),
                            c_codigo = lector.IsDBNull(lector.GetOrdinal("c_codigo")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),

                        });
                    }
                }
            }

            return moneda;
        }

        public IList<CVN_MONEDA> GetAllFilters(CVN_MONEDA entity)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_MONEDA> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public CVN_MONEDA GetByEstado(string estadoNombre)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_MONEDA> GetById(CVN_MONEDA entity)
        {
            throw new NotImplementedException();
        }

        public int Update(CVN_MONEDA entity)
        {
            throw new NotImplementedException();
        }
    }
}
