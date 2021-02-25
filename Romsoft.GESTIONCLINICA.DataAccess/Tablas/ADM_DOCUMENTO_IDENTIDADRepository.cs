using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_DOCUMENTO_IDENTIDADRepository;
using Romsoft.GESTIONCLINICA.Entidades.ADM_DOCUMENTO_IDENTIDAD;
using System;
using System.Collections.Generic;
using System.Data;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class ADM_DOCUMENTO_IDENTIDADRepository : Singleton<ADM_DOCUMENTO_IDENTIDADRepository>, IADM_DOCUMENTO_IDENTIDADRepository<ADM_DOCUMENTO_IDENTIDAD>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);
        #endregion

        public int Add(ADM_DOCUMENTO_IDENTIDAD entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_DOCUMENTO_IDENTIDAD entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_DOCUMENTO_IDENTIDAD entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_IDENTIDAD> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_IDENTIDAD> GetAllActives()
        {
            List<ADM_DOCUMENTO_IDENTIDAD> docidentidad = new List<ADM_DOCUMENTO_IDENTIDAD>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_DOCUMENTO_IDENTIDAD_GetAllActives")))
            {

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        docidentidad.Add(new ADM_DOCUMENTO_IDENTIDAD
                        {
                            id_documento_identidad = lector.IsDBNull(lector.GetOrdinal("id_documento_identidad")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_documento_identidad")),
                            c_codigo = lector.IsDBNull(lector.GetOrdinal("c_codigo")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),

                        });
                    }
                }
            }

            return docidentidad;
        }

        public IList<ADM_DOCUMENTO_IDENTIDAD> GetAllFilters(ADM_DOCUMENTO_IDENTIDAD entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_IDENTIDAD> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_IDENTIDAD> GetById(ADM_DOCUMENTO_IDENTIDAD entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_DOCUMENTO_IDENTIDAD entity)
        {
            throw new NotImplementedException();
        }
    }
}
