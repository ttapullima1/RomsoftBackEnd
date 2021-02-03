using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.ICVN_BENEFICIORepository;
using Romsoft.GESTIONCLINICA.Entidades.CVN_BENEFICIO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class CVN_BENEFICIORepository : Singleton<CVN_BENEFICIORepository>, ICVN_BENEFICIORepository<CVN_BENEFICIO>
    {
        #region Attributos

        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);

        #endregion
        public int Add(CVN_BENEFICIO entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(CVN_BENEFICIO entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(CVN_BENEFICIO entity)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_BENEFICIO> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_BENEFICIO> GetAllActives()
        {
            List<CVN_BENEFICIO> beneficio = new List<CVN_BENEFICIO>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_CVN_BENEFICIO_GetAllActives")))
            {
                //_database.AddInParameter(comando, "@f_estado", DbType.Int32, entity.f_estado);

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        beneficio.Add(new CVN_BENEFICIO
                        {
                            id_beneficio = lector.IsDBNull(lector.GetOrdinal("id_beneficio")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_beneficio")),
                            c_codigo = lector.IsDBNull(lector.GetOrdinal("c_codigo")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),

                        });
                    }
                }
            }

            return beneficio;
        }

        public IList<CVN_BENEFICIO> GetAllFilters(CVN_BENEFICIO entity)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_BENEFICIO> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public CVN_BENEFICIO GetByEstado(string estadoNombre)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_BENEFICIO> GetById(CVN_BENEFICIO entity)
        {
            throw new NotImplementedException();
        }

        public int Update(CVN_BENEFICIO entity)
        {
            throw new NotImplementedException();
        }
    }
}
