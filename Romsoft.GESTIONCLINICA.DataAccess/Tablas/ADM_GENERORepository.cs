using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_GENERORepository;
using Romsoft.GESTIONCLINICA.Entidades.ADM_GENERO;
using System;
using System.Collections.Generic;
using System.Data;


namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class ADM_GENERORepository : Singleton<ADM_GENERORepository>, IADM_GENERORepository<ADM_GENERO>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);
        #endregion

        public int Add(ADM_GENERO entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_GENERO entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_GENERO entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_GENERO> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_GENERO> GetAllActives()
        {
            List<ADM_GENERO> genero = new List<ADM_GENERO>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_GENERO_GetAllActives")))
            {

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        genero.Add(new ADM_GENERO
                        {
                            id_genero = lector.IsDBNull(lector.GetOrdinal("id_genero")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_genero")),
                            c_codigo = lector.IsDBNull(lector.GetOrdinal("c_codigo")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),

                        });
                    }
                }
            }

            return genero;
        }

        public IList<ADM_GENERO> GetAllFilters(ADM_GENERO entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_GENERO> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_GENERO> GetById(ADM_GENERO entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_GENERO entity)
        {
            throw new NotImplementedException();
        }
    }
}
