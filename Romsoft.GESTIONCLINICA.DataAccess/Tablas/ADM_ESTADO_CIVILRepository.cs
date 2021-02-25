using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_ESTADO_CIVILRepository;
using Romsoft.GESTIONCLINICA.Entidades.ADM_ESTADO_CIVIL;
using System;
using System.Collections.Generic;
using System.Data;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class ADM_ESTADO_CIVILRepository : Singleton<ADM_ESTADO_CIVILRepository>, IADM_ESTADO_CIVILRepository<ADM_ESTADO_CIVIL>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);
        #endregion

        public int Add(ADM_ESTADO_CIVIL entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_ESTADO_CIVIL entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_ESTADO_CIVIL entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ESTADO_CIVIL> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ESTADO_CIVIL> GetAllActives()
        {
            List<ADM_ESTADO_CIVIL> estadocivil = new List<ADM_ESTADO_CIVIL>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_ESTADO_CIVIL_GetAllActives")))
            {

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        estadocivil.Add(new ADM_ESTADO_CIVIL
                        {
                            id_estado_civil = lector.IsDBNull(lector.GetOrdinal("id_estado_civil")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_estado_civil")),
                            c_codigo = lector.IsDBNull(lector.GetOrdinal("c_codigo")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),
                            
                        });
                    }
                }
            }

            return estadocivil;
        }

        public IList<ADM_ESTADO_CIVIL> GetAllFilters(ADM_ESTADO_CIVIL entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ESTADO_CIVIL> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ESTADO_CIVIL> GetById(ADM_ESTADO_CIVIL entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_ESTADO_CIVIL entity)
        {
            throw new NotImplementedException();
        }
    }
}
