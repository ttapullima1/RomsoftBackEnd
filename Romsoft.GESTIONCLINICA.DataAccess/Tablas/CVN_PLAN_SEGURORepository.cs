using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.ICVN_PLAN_SEGURORepository;
using Romsoft.GESTIONCLINICA.Entidades.CVN_PLAN_SEGURO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class CVN_PLAN_SEGURORepository : Singleton<CVN_PLAN_SEGURORepository>, ICVN_PLAN_SEGURORepository<CVN_PLAN_SEGURO>
    {
        #region Attributos

        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);


        #endregion


        public int Add(CVN_PLAN_SEGURO entity)
        {
            int id;

            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_CVN_PLAN_SEGURO_Insert")))
            {
                _database.AddInParameter(comando, "@id_contacto_garante", DbType.Int32, entity.id_contacto_garante);
                _database.AddInParameter(comando, "@id_contacto_contratante", DbType.Int32, entity.id_contacto_contratante);
                _database.AddInParameter(comando, "@id_categoria_pago", DbType.Int32, entity.id_categoria_pago);
                _database.AddInParameter(comando, "@c_codigo", DbType.String, entity.c_codigo);
                _database.AddInParameter(comando, "@t_descripcion", DbType.String, entity.t_descripcion);
                _database.AddInParameter(comando, "@t_observacion", DbType.String, entity.t_observacion);
                _database.AddInParameter(comando, "@c_codigo_iafa", DbType.String, entity.c_codigo_iafa);
                _database.AddInParameter(comando, "@d_fecha_i_vigencia", DbType.DateTime, entity.d_fecha_i_vigencia);
                _database.AddInParameter(comando, "@d_fecha_f_vigencia", DbType.DateTime, entity.d_fecha_f_vigencia);
                _database.AddInParameter(comando, "@c_contrato", DbType.String, entity.c_contrato);
                _database.AddInParameter(comando, "@c_certificado", DbType.String, entity.c_certificado);
                _database.AddInParameter(comando, "@id_producto_plan", DbType.Int32, entity.id_producto_plan);
                _database.AddInParameter(comando, "@f_estado", DbType.Int32, entity.f_estado);
                _database.AddInParameter(comando, "@id_user_registro", DbType.Int32, entity.id_usuarioCreacion);
                _database.AddInParameter(comando, "@d_fecha_registro", DbType.DateTime, entity.FechaCreacion);
                _database.AddOutParameter(comando, "@Response", DbType.Int32, 11);

                _database.ExecuteNonQuery(comando);
                id = Convert.ToInt32(_database.GetParameterValue(comando, "@Response"));
            }

            return id;
        }

        public int Delete(CVN_PLAN_SEGURO entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(CVN_PLAN_SEGURO entity)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_PLAN_SEGURO> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_PLAN_SEGURO> GetAllActives()
        {
            List<CVN_PLAN_SEGURO> plan_seguro = new List<CVN_PLAN_SEGURO>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_CVN_PLAN_SEGURO_GetAllActives")))
            {
                //_database.AddInParameter(comando, "@f_estado", DbType.Int32, entity.f_estado);

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        plan_seguro.Add(new CVN_PLAN_SEGURO
                        {

                            id_plan_seguro = lector.IsDBNull(lector.GetOrdinal("id_plan_seguro")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_plan_seguro")),
                            c_codigo = lector.IsDBNull(lector.GetOrdinal("c_codigo")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),

                        });
                    }
                }
            }

            return plan_seguro;
        }

        public IList<CVN_PLAN_SEGURO> GetAllFilters(CVN_PLAN_SEGURO entity)
        {
            List<CVN_PLAN_SEGURO> plan_seguros = new List<CVN_PLAN_SEGURO>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_CVN_PLAN_SEGURO_GetAllFilter")))
            {
                _database.AddInParameter(comando, "@valor", DbType.String, entity.valorRequest);

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        plan_seguros.Add(new CVN_PLAN_SEGURO
                        {

                            id_plan_seguro = lector.IsDBNull(lector.GetOrdinal("id_plan_seguro")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_plan_seguro")),
                            c_codigo = lector.IsDBNull(lector.GetOrdinal("c_codigo")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),
                            garante = lector.IsDBNull(lector.GetOrdinal("garante")) ? default(string) : lector.GetString(lector.GetOrdinal("garante")),
                            contratante = lector.IsDBNull(lector.GetOrdinal("contratante")) ? default(string) : lector.GetString(lector.GetOrdinal("contratante")),
                            c_contrato = lector.IsDBNull(lector.GetOrdinal("c_contrato")) ? default(string) : lector.GetString(lector.GetOrdinal("c_contrato")),
                            d_fecha_f_vigencia = lector.IsDBNull(lector.GetOrdinal("d_fecha_f_vigencia")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_f_vigencia")),
                            producto = lector.IsDBNull(lector.GetOrdinal("producto")) ? default(string) : lector.GetString(lector.GetOrdinal("producto")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(string) : lector.GetString(lector.GetOrdinal("estado")),

                        });
                    }
                }
            }

            return plan_seguros;
        }

        public IList<CVN_PLAN_SEGURO> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<CVN_PLAN_SEGURO> GetById(CVN_PLAN_SEGURO entity)
        {
            List<CVN_PLAN_SEGURO> plan_seguro = new List<CVN_PLAN_SEGURO>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_CVN_PLAN_SEGURO_GetById")))
            {
                _database.AddInParameter(comando, "@id_plan_seguro", DbType.Int32, entity.id_plan_seguro);

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        plan_seguro.Add(new CVN_PLAN_SEGURO
                        {
                            id_plan_seguro = lector.IsDBNull(lector.GetOrdinal("id_plan_seguro")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_plan_seguro")),
                            id_contacto_garante = lector.IsDBNull(lector.GetOrdinal("id_contacto_garante")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_contacto_garante")),
                            id_contacto_contratante = lector.IsDBNull(lector.GetOrdinal("id_contacto_contratante")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_contacto_contratante")),
                            id_categoria_pago = lector.IsDBNull(lector.GetOrdinal("id_categoria_pago")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_categoria_pago")),
                            c_codigo = lector.IsDBNull(lector.GetOrdinal("c_codigo")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo")),
                            t_descripcion = lector.IsDBNull(lector.GetOrdinal("t_descripcion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_descripcion")),
                            t_observacion = lector.IsDBNull(lector.GetOrdinal("t_observacion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_observacion")),
                            c_codigo_iafa = lector.IsDBNull(lector.GetOrdinal("c_codigo_iafa")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo_iafa")),
                            d_fecha_i_vigencia = lector.IsDBNull(lector.GetOrdinal("d_fecha_i_vigencia")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_i_vigencia")),
                            d_fecha_f_vigencia = lector.IsDBNull(lector.GetOrdinal("d_fecha_f_vigencia")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_f_vigencia")),
                            c_contrato = lector.IsDBNull(lector.GetOrdinal("c_contrato")) ? default(string) : lector.GetString(lector.GetOrdinal("c_contrato")),
                            c_certificado = lector.IsDBNull(lector.GetOrdinal("c_certificado")) ? default(string) : lector.GetString(lector.GetOrdinal("c_certificado")),
                            id_producto_plan = lector.IsDBNull(lector.GetOrdinal("id_producto_plan")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_producto_plan")),
                            f_estado = lector.IsDBNull(lector.GetOrdinal("f_estado")) ? default(int) : lector.GetInt32(lector.GetOrdinal("f_estado")),
                            id_usuarioCreacion = lector.IsDBNull(lector.GetOrdinal("id_user_registro")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_user_registro")),
                            id_usuarioModifica = lector.IsDBNull(lector.GetOrdinal("id_user_modifica")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_user_modifica")),
                            FechaCreacion = lector.IsDBNull(lector.GetOrdinal("d_fecha_registro")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_registro")),
                             FechaModificacion = lector.IsDBNull(lector.GetOrdinal("d_fecha_modifica")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_modifica"))

                        });
                    }
                }
            }

            return plan_seguro;
        }

        public int Update(CVN_PLAN_SEGURO entity)
        {
            int id;

            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_CVN_PLAN_SEGURO_Update")))
            {
                //
                _database.AddInParameter(comando, "@id_plan_seguro", DbType.Int32, entity.id_plan_seguro);
                _database.AddInParameter(comando, "@id_contacto_garante", DbType.Int32, entity.id_contacto_garante);
                _database.AddInParameter(comando, "@id_contacto_contratante", DbType.Int32, entity.id_contacto_contratante);
                _database.AddInParameter(comando, "@id_categoria_pago", DbType.Int32, entity.id_categoria_pago);
                _database.AddInParameter(comando, "@c_codigo", DbType.String, entity.c_codigo);
                _database.AddInParameter(comando, "@t_descripcion", DbType.String, entity.t_descripcion);
                _database.AddInParameter(comando, "@t_observacion", DbType.String, entity.t_observacion);
                _database.AddInParameter(comando, "@c_codigo_iafa", DbType.String, entity.c_codigo_iafa);
                _database.AddInParameter(comando, "@d_fecha_i_vigencia", DbType.DateTime, entity.d_fecha_i_vigencia);
                _database.AddInParameter(comando, "@d_fecha_f_vigencia", DbType.DateTime, entity.d_fecha_f_vigencia);
                _database.AddInParameter(comando, "@c_contrato", DbType.String, entity.c_contrato);
                _database.AddInParameter(comando, "@c_certificado", DbType.String, entity.c_certificado);
                _database.AddInParameter(comando, "@id_producto_plan", DbType.Int32, entity.id_producto_plan);
                _database.AddInParameter(comando, "@f_estado", DbType.Int32, entity.f_estado);
                _database.AddInParameter(comando, "@id_user_modifica", DbType.Int32, entity.id_usuarioModifica);
                _database.AddInParameter(comando, "@d_fecha_modifica", DbType.DateTime, entity.FechaModificacion);
                _database.AddOutParameter(comando, "@Response", DbType.Int32, 11);

                _database.ExecuteNonQuery(comando);
                id = Convert.ToInt32(_database.GetParameterValue(comando, "@Response"));
            }

            return id;
        }
    }
}
