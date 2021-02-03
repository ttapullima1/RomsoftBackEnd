using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.ICON_CONTACTORepository;
using Romsoft.GESTIONCLINICA.Entidades.CON_CONTACTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class CON_CONTACTORepository : Singleton<CON_CONTACTORepository>, ICON_CONTACTORepository<CON_CONTACTO>
    {
        #region Attributos

        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);

        #endregion

        public int Add(CON_CONTACTO entity)
        {
            int id;

            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_CON_CONTACTO_Insert")))
            {
                _database.AddInParameter(comando, "@id_tipo_contacto", DbType.Int32, entity.id_tipo_contacto);
                _database.AddInParameter(comando, "@c_codigo", DbType.String, entity.c_codigo);
                _database.AddInParameter(comando, "@c_codigo_sunat", DbType.String, entity.c_codigo_sunat);
                _database.AddInParameter(comando, "@t_apellidos", DbType.String, entity.t_apellidos);
                _database.AddInParameter(comando, "@t_nombres", DbType.String, entity.t_nombres);
                _database.AddInParameter(comando, "@t_razon_social", DbType.String, entity.t_razon_social);
                _database.AddInParameter(comando, "@t_razon_comercial", DbType.String, entity.t_razon_comercial);
                _database.AddInParameter(comando, "@t_observacion", DbType.String, entity.t_observacion);
                _database.AddInParameter(comando, "@t_contacto", DbType.String, entity.t_contacto);
                _database.AddInParameter(comando, "@t_actividad_economica", DbType.String, entity.t_actividad_economica);
                _database.AddInParameter(comando, "@c_telefono1", DbType.String, entity.c_telefono1);
                _database.AddInParameter(comando, "@c_telefono2", DbType.String, entity.c_telefono2);
                _database.AddInParameter(comando, "@t_email_ffee", DbType.String, entity.t_email_ffee);
                _database.AddInParameter(comando, "@n_dias_credito", DbType.Int32, entity.n_dias_credito);
                _database.AddInParameter(comando, "@n_flag_garante", DbType.Int32, entity.n_flag_garante);
                _database.AddInParameter(comando, "@n_flag_contratante", DbType.Int32, entity.n_flag_contratante);
                _database.AddInParameter(comando, "@n_flag_proveedor", DbType.Int32, entity.n_flag_proveedor);
                _database.AddInParameter(comando, "@n_flag_habido", DbType.Int32, entity.n_flag_habido);
                _database.AddInParameter(comando, "@f_estado", DbType.Int32, entity.f_estado);
                _database.AddInParameter(comando, "@t_direccion", DbType.Int32, entity.t_direccion);
                _database.AddInParameter(comando, "@id_user_registro", DbType.Int32, entity.id_usuarioCreacion);
                _database.AddOutParameter(comando, "@Response", DbType.Int32, 11);

                _database.ExecuteNonQuery(comando);
                id = Convert.ToInt32(_database.GetParameterValue(comando, "@Response"));
            }

            return id;
        }

        public int Delete(CON_CONTACTO entity)
        {
            int idResult;

            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_CON_CONTACTO_Delete")))
            {
                _database.AddInParameter(comando, "@id_contacto", DbType.Int32, entity.id_contacto);
                _database.AddOutParameter(comando, "@Response", DbType.Int32, 11);

                _database.ExecuteNonQuery(comando);
                idResult = Convert.ToInt32(_database.GetParameterValue(comando, "@Response"));
            }

            return idResult;
        }

        public bool Exists(CON_CONTACTO entity)
        {
            bool existe = false;
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_CON_CONTACTO_VerifyExists")))
            {
                _database.AddInParameter(comando, "@c_codigo", DbType.String, entity.c_codigo);
                _database.AddInParameter(comando, "@t_razon_social", DbType.String, entity.t_razon_social);

                using (var lector = _database.ExecuteReader(comando))
                {
                    if (lector.Read())
                    {
                        existe = Convert.ToBoolean(lector.GetInt32(0));
                    }
                }
            }

            return existe;
        }

        public IList<CON_CONTACTO> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<CON_CONTACTO> GetAllActives()
        {
            List<CON_CONTACTO> concontacto = new List<CON_CONTACTO>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_CON_CONTACTO_GetAllActives")))
            {
                //_database.AddInParameter(comando, "@f_estado", DbType.Int32, entity.f_estado);

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        concontacto.Add(new CON_CONTACTO
                        {
                            id_contacto = lector.IsDBNull(lector.GetOrdinal("id_contacto")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_contacto")),
                            c_codigo = lector.IsDBNull(lector.GetOrdinal("c_codigo")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo")),
                            t_razon_social = lector.IsDBNull(lector.GetOrdinal("t_razon_social")) ? default(string) : lector.GetString(lector.GetOrdinal("t_razon_social")),

                        });
                    }
                }
            }

            return concontacto;
        }

        public IList<CON_CONTACTO> GetAllFilters(CON_CONTACTO entity)
        {
            List<CON_CONTACTO> concontacto = new List<CON_CONTACTO>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_CON_CONTACTO_GetAllFilter")))
            {
                _database.AddInParameter(comando, "@valor", DbType.String, entity.valor);

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        concontacto.Add(new CON_CONTACTO
                        {
                            
                            
                            id_contacto = lector.IsDBNull(lector.GetOrdinal("id_contacto")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_contacto")),
                            codigo_tc = lector.IsDBNull(lector.GetOrdinal("codigo_tc")) ? default(string) : lector.GetString(lector.GetOrdinal("codigo_tc")),
                            c_codigo = lector.IsDBNull(lector.GetOrdinal("c_codigo")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo")),
                            t_razon_social = lector.IsDBNull(lector.GetOrdinal("t_razon_social")) ? default(string) : lector.GetString(lector.GetOrdinal("t_razon_social")),
                            t_contacto = lector.IsDBNull(lector.GetOrdinal("t_contacto")) ? default(string) : lector.GetString(lector.GetOrdinal("t_contacto")),
                            t_email_ffee = lector.IsDBNull(lector.GetOrdinal("t_email_ffee")) ? default(string) : lector.GetString(lector.GetOrdinal("t_email_ffee")),
                            f_estado = lector.IsDBNull(lector.GetOrdinal("f_estado")) ? default(int) : lector.GetInt32(lector.GetOrdinal("f_estado")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(string) : lector.GetString(lector.GetOrdinal("estado")),

                        });
                    }
                }
            }

            return concontacto;
        }

        public IList<CON_CONTACTO> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public CON_CONTACTO GetByEstado(string estadoNombre)
        {
            throw new NotImplementedException();
        }

        public IList<CON_CONTACTO> GetById(CON_CONTACTO entity)
        {
            List<CON_CONTACTO> concontacto = new List<CON_CONTACTO>();

            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_CON_CONTACTO_GetById")))
            {
                _database.AddInParameter(comando, "@id_contacto", DbType.Int32, entity.id_contacto);

                using (var lector = _database.ExecuteReader(comando))
                {
                    if (lector.Read())
                    {
                        concontacto.Add(new CON_CONTACTO
                        {
                           id_contacto = lector.IsDBNull(lector.GetOrdinal("id_contacto")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_contacto")),
                            id_tipo_contacto = lector.IsDBNull(lector.GetOrdinal("id_tipo_contacto")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_tipo_contacto")),
                            c_codigo = lector.IsDBNull(lector.GetOrdinal("c_codigo")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo")),
                            c_codigo_sunat = lector.IsDBNull(lector.GetOrdinal("c_codigo_sunat")) ? default(string) : lector.GetString(lector.GetOrdinal("c_codigo_sunat")),
                            t_apellidos = lector.IsDBNull(lector.GetOrdinal("t_apellidos")) ? default(string) : lector.GetString(lector.GetOrdinal("t_apellidos")),
                            t_nombres = lector.IsDBNull(lector.GetOrdinal("t_nombres")) ? default(string) : lector.GetString(lector.GetOrdinal("t_nombres")),
                            t_razon_social = lector.IsDBNull(lector.GetOrdinal("t_razon_social")) ? default(string) : lector.GetString(lector.GetOrdinal("t_razon_social")),
                            t_razon_comercial = lector.IsDBNull(lector.GetOrdinal("t_razon_comercial")) ? default(string) : lector.GetString(lector.GetOrdinal("t_razon_comercial")),
                            t_observacion = lector.IsDBNull(lector.GetOrdinal("t_observacion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_observacion")),
                            t_direccion = lector.IsDBNull(lector.GetOrdinal("t_direccion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_direccion")),
                            t_contacto = lector.IsDBNull(lector.GetOrdinal("t_contacto")) ? default(string) : lector.GetString(lector.GetOrdinal("t_contacto")),
                            t_actividad_economica = lector.IsDBNull(lector.GetOrdinal("t_actividad_economica")) ? default(string) : lector.GetString(lector.GetOrdinal("t_actividad_economica")),
                            c_telefono1 = lector.IsDBNull(lector.GetOrdinal("c_telefono1")) ? default(string) : lector.GetString(lector.GetOrdinal("c_telefono1")),
                            c_telefono2 = lector.IsDBNull(lector.GetOrdinal("c_telefono2")) ? default(string) : lector.GetString(lector.GetOrdinal("c_telefono2")),
                            t_email_ffee = lector.IsDBNull(lector.GetOrdinal("t_email_ffee")) ? default(string) : lector.GetString(lector.GetOrdinal("t_email_ffee")),
                            n_dias_credito = lector.IsDBNull(lector.GetOrdinal("n_dias_credito")) ? default(int) : lector.GetInt32(lector.GetOrdinal("n_dias_credito")),
                            n_flag_garante = lector.IsDBNull(lector.GetOrdinal("n_flag_garante")) ? default(int) : lector.GetInt32(lector.GetOrdinal("n_flag_garante")),
                            n_flag_contratante = lector.IsDBNull(lector.GetOrdinal("n_flag_contratante")) ? default(int) : lector.GetInt32(lector.GetOrdinal("n_flag_contratante")),
                            n_flag_proveedor = lector.IsDBNull(lector.GetOrdinal("n_flag_proveedor")) ? default(int) : lector.GetInt32(lector.GetOrdinal("n_flag_proveedor")),
                            n_flag_habido = lector.IsDBNull(lector.GetOrdinal("n_flag_habido")) ? default(int) : lector.GetInt32(lector.GetOrdinal("n_flag_habido")),
                            f_estado = lector.IsDBNull(lector.GetOrdinal("f_estado")) ? default(int) : lector.GetInt32(lector.GetOrdinal("f_estado")),
                            id_usuarioCreacion = lector.IsDBNull(lector.GetOrdinal("id_user_registro")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_user_registro")),
                            id_usuarioModifica = lector.IsDBNull(lector.GetOrdinal("id_user_modifica")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_user_modifica")),
                            FechaCreacion = lector.IsDBNull(lector.GetOrdinal("d_fecha_registro")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_registro")),
                            FechaModificacion = lector.IsDBNull(lector.GetOrdinal("d_fecha_modifica")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_modifica"))
                        });
                    }
                }
            }

            return concontacto;
        }

        public int Update(CON_CONTACTO entity)
        {
            int id;

            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_CON_CONTACTO_Update")))
            {
                _database.AddInParameter(comando, "@id_contacto", DbType.Int32, entity.id_contacto);
                _database.AddInParameter(comando, "@id_tipo_contacto", DbType.Int32, entity.id_tipo_contacto);
                _database.AddInParameter(comando, "@c_codigo", DbType.String, entity.c_codigo);
                _database.AddInParameter(comando, "@c_codigo_sunat", DbType.String, entity.c_codigo_sunat);
                _database.AddInParameter(comando, "@t_apellidos", DbType.String, entity.t_apellidos);
                _database.AddInParameter(comando, "@t_nombres", DbType.String, entity.t_nombres);
                _database.AddInParameter(comando, "@t_razon_social", DbType.String, entity.t_razon_social);
                _database.AddInParameter(comando, "@t_razon_comercial", DbType.String, entity.t_razon_comercial);
                _database.AddInParameter(comando, "@t_observacion", DbType.String, entity.t_observacion);
                _database.AddInParameter(comando, "@t_direccion", DbType.String, entity.t_direccion);
                _database.AddInParameter(comando, "@t_contacto", DbType.String, entity.t_contacto);
                _database.AddInParameter(comando, "@t_actividad_economica", DbType.String, entity.t_actividad_economica);
                _database.AddInParameter(comando, "@c_telefono1", DbType.String, entity.c_telefono1);
                _database.AddInParameter(comando, "@c_telefono2", DbType.String, entity.c_telefono2);
                _database.AddInParameter(comando, "@t_email_ffee", DbType.String, entity.t_email_ffee);
                _database.AddInParameter(comando, "@n_dias_credito", DbType.Int32, entity.n_dias_credito);
                _database.AddInParameter(comando, "@n_flag_garante", DbType.Int32, entity.n_flag_garante);
                _database.AddInParameter(comando, "@n_flag_contratante", DbType.Int32, entity.n_flag_contratante);
                _database.AddInParameter(comando, "@n_flag_proveedor", DbType.Int32, entity.n_flag_proveedor);
                _database.AddInParameter(comando, "@n_flag_habido", DbType.Int32, entity.n_flag_habido);
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
