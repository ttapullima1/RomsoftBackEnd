using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_UBIGEORepository;
using Romsoft.GESTIONCLINICA.Entidades.ADM_UBIGEO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class ADM_UBIGEORepository : Singleton<ADM_UBIGEORepository>, IADM_UBIGEORepository<ADM_UBIGEO>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);
        #endregion

        public int Add(ADM_UBIGEO entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_UBIGEO entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_UBIGEO entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_UBIGEO> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_UBIGEO> GetAllActives()
        {
            List<ADM_UBIGEO> ubigeo = new List<ADM_UBIGEO>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_UBIGEO_GetAllActives")))
            {

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        ubigeo.Add(new ADM_UBIGEO
                        {
                            id_ubigeo = lector.IsDBNull(lector.GetOrdinal("id_ubigeo")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_ubigeo")),
                            c_codigo = lector.IsDBNull(lector.GetOrdinal("c_codigo")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo")),
                            t_pais = lector.IsDBNull(lector.GetOrdinal("t_pais")) ? default(string) : lector.GetString(lector.GetOrdinal("t_pais")),
                            t_departamento = lector.IsDBNull(lector.GetOrdinal("t_departamento")) ? default(string) : lector.GetString(lector.GetOrdinal("t_departamento")),
                            t_provincia = lector.IsDBNull(lector.GetOrdinal("t_provincia")) ? default(string) : lector.GetString(lector.GetOrdinal("t_provincia")),
                            t_distrito  = lector.IsDBNull(lector.GetOrdinal("t_distrito")) ? default(string) : lector.GetString(lector.GetOrdinal("t_distrito")),

                        });
                    }
                }
            }

            return ubigeo;
        }

        public IList<ADM_UBIGEO> GetAllFilters(ADM_UBIGEO entity)
        {
            List<ADM_UBIGEO> ubigeo = new List<ADM_UBIGEO>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_UBIGEO_GetAllFilters")))
            {
                _database.AddInParameter(comando, "@valor", DbType.String, entity.ValorBusqueda);

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        ubigeo.Add(new ADM_UBIGEO
                        {

                            id_ubigeo = lector.IsDBNull(lector.GetOrdinal("id_ubigeo")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_ubigeo")),
                            c_codigo = lector.IsDBNull(lector.GetOrdinal("c_codigo")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo")),
                            t_pais = lector.IsDBNull(lector.GetOrdinal("t_pais")) ? default(string) : lector.GetString(lector.GetOrdinal("t_pais")),
                            t_departamento = lector.IsDBNull(lector.GetOrdinal("t_departamento")) ? default(string) : lector.GetString(lector.GetOrdinal("t_departamento")),
                            t_provincia = lector.IsDBNull(lector.GetOrdinal("t_provincia")) ? default(string) : lector.GetString(lector.GetOrdinal("t_provincia")),
                            t_distrito = lector.IsDBNull(lector.GetOrdinal("t_distrito")) ? default(string) : lector.GetString(lector.GetOrdinal("t_distrito")),

                        });
                    }
                }
            }

            return ubigeo;
        }

        public IList<ADM_UBIGEO> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_UBIGEO> GetById(ADM_UBIGEO entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_UBIGEO entity)
        {
            throw new NotImplementedException();
        }
    }
}
