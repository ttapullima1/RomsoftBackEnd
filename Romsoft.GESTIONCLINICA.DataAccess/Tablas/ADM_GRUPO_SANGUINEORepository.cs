using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_GRUPO_SANGUINEORepository;
using Romsoft.GESTIONCLINICA.Entidades.ADM_GRUPO_SANGUINEO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class ADM_GRUPO_SANGUINEORepository : Singleton<ADM_GRUPO_SANGUINEORepository>, IADM_GRUPO_SANGUINEORepository<ADM_GRUPO_SANGUINEO>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);
        #endregion
        public int Add(ADM_GRUPO_SANGUINEO entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_GRUPO_SANGUINEO entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_GRUPO_SANGUINEO entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_GRUPO_SANGUINEO> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_GRUPO_SANGUINEO> GetAllActives()
        {
            List<ADM_GRUPO_SANGUINEO> gsanguineo = new List<ADM_GRUPO_SANGUINEO>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_GRUPO_SANGUINEO_GetAllActives")))
            {

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        gsanguineo.Add(new ADM_GRUPO_SANGUINEO
                        {
                            id_grupo_sanguineo = lector.IsDBNull(lector.GetOrdinal("id_grupo_sanguineo")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_grupo_sanguineo")),
                            c_codigo = lector.IsDBNull(lector.GetOrdinal("c_codigo")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),

                        });
                    }
                }
            }

            return gsanguineo;
        }

        public IList<ADM_GRUPO_SANGUINEO> GetAllFilters(ADM_GRUPO_SANGUINEO entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_GRUPO_SANGUINEO> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_GRUPO_SANGUINEO> GetById(ADM_GRUPO_SANGUINEO entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_GRUPO_SANGUINEO entity)
        {
            throw new NotImplementedException();
        }
    }
}
