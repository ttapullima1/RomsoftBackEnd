using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.ICVN_PLAN_SEGURO_DETALLERepository;
using Romsoft.GESTIONCLINICA.Entidades.CVN_PLAN_SEGURO_DETALLE;
using System;
using System.Collections.Generic;
using System.Data;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class CVN_PLAN_SEGURO_DETALLERepository : Singleton<CVN_PLAN_SEGURO_DETALLERepository>, ICVN_PLAN_SEGURO_DETALLERepository<CVN_PLAN_SEGURO_DETALLE>
    {
        #region Attributos

        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);


        #endregion

        public int Add(CVN_PLAN_SEGURO_DETALLE entity)
        {
            int id;

            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_CVN_PLAN_SEGURO_DETALLE_Insert")))
            {
                _database.AddInParameter(comando, "@id_plan_seguro", DbType.Int32, entity.id_plan_seguro);
                _database.AddInParameter(comando, "@id_beneficio", DbType.Int32, entity.id_beneficio);
                _database.AddInParameter(comando, "@id_moneda", DbType.Int32, entity.id_moneda);
                _database.AddInParameter(comando, "@n_copago_fijo", DbType.Decimal, entity.n_copago_fijo);
                _database.AddInParameter(comando, "@n_copago_variable", DbType.Decimal, entity.n_copago_variable);
                _database.AddInParameter(comando, "@n_copago_variable_farmacia", DbType.Decimal, entity.n_copago_variable_farmacia);
                _database.AddInParameter(comando, "@f_estado", DbType.Int32, entity.f_estado);
                _database.AddInParameter(comando, "@id_user_registro", DbType.Int32, entity.id_usuarioCreacion);
                _database.AddInParameter(comando, "@d_fecha_registro", DbType.DateTime, entity.FechaCreacion);
                _database.AddOutParameter(comando, "@Response", DbType.Int32, 11);

                _database.ExecuteNonQuery(comando);
                id = Convert.ToInt32(_database.GetParameterValue(comando, "@Response"));
            }

            return id;
        }

        public int Delete(CVN_PLAN_SEGURO_DETALLE entity)
        {
            int idResult;

            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_CVN_PLAN_SEGURO_DETALLE_Delete")))
            {
                _database.AddInParameter(comando, "@id_plan_seguro_detalle", DbType.Int32, entity.id_plan_seguro_detalle);
                _database.AddOutParameter(comando, "@Response", DbType.Int32, 11);

                _database.ExecuteNonQuery(comando);
                idResult = Convert.ToInt32(_database.GetParameterValue(comando, "@Response"));
            }

            return idResult;
        }

        public bool Exists(CVN_PLAN_SEGURO_DETALLE entity)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_PLAN_SEGURO_DETALLE> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_PLAN_SEGURO_DETALLE> GetAllActives()
        {
            throw new NotImplementedException();
        }

        public IList<CVN_PLAN_SEGURO_DETALLE> GetAllActivesFilters(CVN_PLAN_SEGURO_DETALLE entity)
        {
            List<CVN_PLAN_SEGURO_DETALLE> pagoprecio_segus = new List<CVN_PLAN_SEGURO_DETALLE>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_CVN_PLAN_SEGURO_DETALLE_GetAllActives")))
            {
                _database.AddInParameter(comando, "@id_plan_seguro", DbType.Int32, entity.id_plan_seguro);

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        pagoprecio_segus.Add(new CVN_PLAN_SEGURO_DETALLE
                        {
                            id_plan_seguro_detalle = lector.IsDBNull(lector.GetOrdinal("id_plan_seguro_detalle")) ? default(Int64) : lector.GetInt64(lector.GetOrdinal("id_plan_seguro_detalle")),
                            id_plan_seguro = lector.IsDBNull(lector.GetOrdinal("id_plan_seguro")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_plan_seguro")),
                            id_beneficio = lector.IsDBNull(lector.GetOrdinal("id_beneficio")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_beneficio")),
                            codigo = lector.IsDBNull(lector.GetOrdinal("codigo")) ? default(string) : lector.GetString(lector.GetOrdinal("codigo")),
                            beneficio = lector.IsDBNull(lector.GetOrdinal("beneficio")) ? default(string) : lector.GetString(lector.GetOrdinal("beneficio")),
                            moneda = lector.IsDBNull(lector.GetOrdinal("moneda")) ? default(string) : lector.GetString(lector.GetOrdinal("moneda")),
                            n_copago_fijo = lector.IsDBNull(lector.GetOrdinal("n_copago_fijo")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_copago_fijo")),
                            n_copago_variable = lector.IsDBNull(lector.GetOrdinal("n_copago_variable")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_copago_variable")),
                            n_copago_variable_farmacia = lector.IsDBNull(lector.GetOrdinal("n_copago_variable_farmacia")) ? default(decimal) : lector.GetDecimal(lector.GetOrdinal("n_copago_variable_farmacia")),
                            f_estado = lector.IsDBNull(lector.GetOrdinal("f_estado")) ? default(int) : lector.GetInt32(lector.GetOrdinal("f_estado")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(string) : lector.GetString(lector.GetOrdinal("estado")),

                        });
                    }
                }
            }

            return pagoprecio_segus;
        }

        public IList<CVN_PLAN_SEGURO_DETALLE> GetAllFilters(CVN_PLAN_SEGURO_DETALLE entity)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_PLAN_SEGURO_DETALLE> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_PLAN_SEGURO_DETALLE> GetById(CVN_PLAN_SEGURO_DETALLE entity)
        {
            throw new NotImplementedException();
        }

        public int Update(CVN_PLAN_SEGURO_DETALLE entity)
        {
            throw new NotImplementedException();
        }
    }
}
