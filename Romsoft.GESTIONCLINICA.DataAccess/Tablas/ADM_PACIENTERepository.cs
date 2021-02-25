using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_PACIENTERepository;
using Romsoft.GESTIONCLINICA.Entidades.ADM_PACIENTE;
using System;
using System.Collections.Generic;
using System.Data;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class ADM_PACIENTERepository : Singleton<ADM_PACIENTERepository>, IADM_PACIENTERepository<ADM_PACIENTE>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);

        #endregion

        public int Add(ADM_PACIENTE entity)
        {
            int id;

            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_PACIENTE_Insert")))
            {
                _database.AddInParameter(comando, "@n_historia_clinica", DbType.Int32, entity.n_historia_clinica);
                _database.AddInParameter(comando, "@t_apellido_paterno", DbType.String, entity.t_apellido_paterno);
                _database.AddInParameter(comando, "@t_apellido_materno", DbType.String, entity.t_apellido_materno);
                _database.AddInParameter(comando, "@t_nombres", DbType.String, entity.t_nombres);
                _database.AddInParameter(comando, "@t_paciente", DbType.String, entity.t_paciente);
                _database.AddInParameter(comando, "@d_fecha_nacimiento", DbType.DateTime, entity.d_fecha_nacimiento);
                _database.AddInParameter(comando, "@id_genero", DbType.Int32, entity.id_genero);
                _database.AddInParameter(comando, "@id_estado_civil", DbType.Int32, entity.id_estado_civil);
                _database.AddInParameter(comando, "@id_documento_identidad", DbType.Int32, entity.id_documento_identidad);
                _database.AddInParameter(comando, "@c_documento_identidad", DbType.String, entity.c_documento_identidad);
                _database.AddInParameter(comando, "@id_grupo_sanguineo", DbType.Int32, entity.id_grupo_sanguineo);
                _database.AddInParameter(comando, "@id_ocupacion", DbType.Int32, entity.id_ocupacion);
                _database.AddInParameter(comando, "@t_ocupacion", DbType.String, entity.t_ocupacion);
                _database.AddInParameter(comando, "@t_email_paciente", DbType.String, entity.t_email_paciente);
                _database.AddInParameter(comando, "@c_p_fono_casa", DbType.String, entity.c_p_fono_casa);
                _database.AddInParameter(comando, "@c_p_fono_personal", DbType.String, entity.c_p_fono_personal);
                _database.AddInParameter(comando, "@c_p_fono_corporativo", DbType.String, entity.c_p_fono_corporativo);
                _database.AddInParameter(comando, "@id_ubigeo_nacimiento", DbType.Int32, entity.id_ubigeo_nacimiento);
                _database.AddInParameter(comando, "@id_ubigeo_domicilio", DbType.Int32, entity.id_ubigeo_domicilio);
                _database.AddInParameter(comando, "@t_referencia", DbType.String, entity.t_referencia);
                _database.AddInParameter(comando, "@t_direccion", DbType.String, entity.t_direccion);
                _database.AddInParameter(comando, "@t_responsable", DbType.String, entity.t_responsable);
                _database.AddInParameter(comando, "@t_email_responsable", DbType.String, entity.t_email_responsable);
                _database.AddInParameter(comando, "@c_r_fono_casa", DbType.String, entity.c_r_fono_casa);
                _database.AddInParameter(comando, "@c_r_fono_personal", DbType.String, entity.c_r_fono_personal);
                _database.AddInParameter(comando, "@f_estado", DbType.Int32, entity.f_estado);
                _database.AddInParameter(comando, "@id_user_registro", DbType.Int32, entity.id_usuarioCreacion);
                _database.AddInParameter(comando, "@d_fecha_registro", DbType.DateTime, entity.FechaCreacion);
                _database.AddOutParameter(comando, "@Response", DbType.Int32, 11);

                _database.ExecuteNonQuery(comando);
                id = Convert.ToInt32(_database.GetParameterValue(comando, "@Response"));
            }

            return id;
        }

        public int Delete(ADM_PACIENTE entity)
        {
            int idResult;

            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_PACIENTE_Delete")))
            {
                _database.AddInParameter(comando, "@id_paciente", DbType.Int32, entity.id_paciente);
                _database.AddOutParameter(comando, "@Response", DbType.Int32, 11);

                _database.ExecuteNonQuery(comando);
                idResult = Convert.ToInt32(_database.GetParameterValue(comando, "@Response"));
            }

            return idResult;
        }

        public bool Exists(ADM_PACIENTE entity)
        {
            bool existe = false;
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_PACIENTE_VerifyExists")))
            {
                _database.AddInParameter(comando, "@n_historia_clinica", DbType.String, entity.n_historia_clinica);

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

        public IList<ADM_PACIENTE> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_PACIENTE> GetAllActives()
        {
            throw new NotImplementedException();
        }

        public IList<ADM_PACIENTE> GetAllFilters(ADM_PACIENTE entity)
        {
            List<ADM_PACIENTE> paciente = new List<ADM_PACIENTE>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_PACIENTE_GetAllFilter")))
            {
                _database.AddInParameter(comando, "@valor", DbType.String, entity.valorRequest);

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        paciente.Add(new ADM_PACIENTE
                        {

                            id_paciente = lector.IsDBNull(lector.GetOrdinal("id_paciente")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_paciente")),
                            historia_clinica = lector.IsDBNull(lector.GetOrdinal("historia_clinica")) ? default(string) : lector.GetString(lector.GetOrdinal("historia_clinica")),
                            t_paciente = lector.IsDBNull(lector.GetOrdinal("t_paciente")) ? default(string) : lector.GetString(lector.GetOrdinal("t_paciente")),
                            sexo = lector.IsDBNull(lector.GetOrdinal("sexo")) ? default(string) : lector.GetString(lector.GetOrdinal("sexo")),
                            d_fecha_nacimiento = lector.IsDBNull(lector.GetOrdinal("d_fecha_nacimiento")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_nacimiento")),
                            t_direccion = lector.IsDBNull(lector.GetOrdinal("t_direccion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_direccion")),
                            c_p_fono_personal = lector.IsDBNull(lector.GetOrdinal("telefono")) ? default(string) : lector.GetString(lector.GetOrdinal("telefono")),
                            t_email_paciente = lector.IsDBNull(lector.GetOrdinal("t_email_paciente")) ? default(string) : lector.GetString(lector.GetOrdinal("t_email_paciente")),
                            //estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(string) : lector.GetString(lector.GetOrdinal("estado")),

                        });
                    }
                }
            }

            return paciente;
        }

        public IList<ADM_PACIENTE> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_PACIENTE> GetById(ADM_PACIENTE entity)
        {
            List<ADM_PACIENTE> paciente = new List<ADM_PACIENTE>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_PACIENTE_GetById")))
            {
                _database.AddInParameter(comando, "@id_paciente", DbType.Int32, entity.id_paciente);

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        paciente.Add(new ADM_PACIENTE
                        {
                            n_historia_clinica = lector.IsDBNull(lector.GetOrdinal("n_historia_clinica")) ? default(int) : lector.GetInt32(lector.GetOrdinal("n_historia_clinica")),
                            t_apellido_paterno = lector.IsDBNull(lector.GetOrdinal("t_apellido_paterno")) ? default(string) : lector.GetString(lector.GetOrdinal("t_apellido_paterno")),
                            t_apellido_materno = lector.IsDBNull(lector.GetOrdinal("t_apellido_materno")) ? default(string) : lector.GetString(lector.GetOrdinal("t_apellido_materno")),
                            t_nombres = lector.IsDBNull(lector.GetOrdinal("t_nombres")) ? default(string) : lector.GetString(lector.GetOrdinal("t_nombres")),
                            t_paciente = lector.IsDBNull(lector.GetOrdinal("t_paciente")) ? default(string) : lector.GetString(lector.GetOrdinal("t_paciente")),
                            d_fecha_nacimiento = lector.IsDBNull(lector.GetOrdinal("d_fecha_nacimiento")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_nacimiento")),
                            id_genero = lector.IsDBNull(lector.GetOrdinal("id_genero")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_genero")),
                            id_estado_civil = lector.IsDBNull(lector.GetOrdinal("id_estado_civil")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_estado_civil")),
                            id_documento_identidad = lector.IsDBNull(lector.GetOrdinal("id_documento_identidad")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_documento_identidad")),
                            c_documento_identidad = lector.IsDBNull(lector.GetOrdinal("c_documento_identidad")) ? default(string) : lector.GetString(lector.GetOrdinal("c_documento_identidad")),
                            id_grupo_sanguineo = lector.IsDBNull(lector.GetOrdinal("id_grupo_sanguineo")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_grupo_sanguineo")),
                            id_ocupacion = lector.IsDBNull(lector.GetOrdinal("id_ocupacion")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_ocupacion")),
                            t_ocupacion = lector.IsDBNull(lector.GetOrdinal("t_ocupacion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_ocupacion")),
                            t_email_paciente = lector.IsDBNull(lector.GetOrdinal("t_email_paciente")) ? default(string) : lector.GetString(lector.GetOrdinal("t_email_paciente")),
                            c_p_fono_casa = lector.IsDBNull(lector.GetOrdinal("c_p_fono_casa")) ? default(string) : lector.GetString(lector.GetOrdinal("c_p_fono_casa")),
                            c_p_fono_personal = lector.IsDBNull(lector.GetOrdinal("c_p_fono_personal")) ? default(string) : lector.GetString(lector.GetOrdinal("c_p_fono_personal")),
                            c_p_fono_corporativo = lector.IsDBNull(lector.GetOrdinal("c_p_fono_corporativo")) ? default(string) : lector.GetString(lector.GetOrdinal("c_p_fono_corporativo")),
                            id_ubigeo_nacimiento = lector.IsDBNull(lector.GetOrdinal("id_ubigeo_nacimiento")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_ubigeo_nacimiento")),
                            id_ubigeo_domicilio = lector.IsDBNull(lector.GetOrdinal("id_ubigeo_domicilio")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_ubigeo_domicilio")),
                            t_referencia = lector.IsDBNull(lector.GetOrdinal("t_referencia")) ? default(string) : lector.GetString(lector.GetOrdinal("t_referencia")),
                            t_direccion = lector.IsDBNull(lector.GetOrdinal("t_direccion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_direccion")),
                            t_responsable = lector.IsDBNull(lector.GetOrdinal("t_responsable")) ? default(string) : lector.GetString(lector.GetOrdinal("t_responsable")),
                            t_email_responsable = lector.IsDBNull(lector.GetOrdinal("t_email_responsable")) ? default(string) : lector.GetString(lector.GetOrdinal("t_email_responsable")),
                            c_r_fono_casa = lector.IsDBNull(lector.GetOrdinal("c_r_fono_casa")) ? default(string) : lector.GetString(lector.GetOrdinal("c_r_fono_casa")),
                            c_r_fono_personal = lector.IsDBNull(lector.GetOrdinal("c_r_fono_personal")) ? default(string) : lector.GetString(lector.GetOrdinal("c_r_fono_personal")),
                            f_estado = lector.IsDBNull(lector.GetOrdinal("f_estado")) ? default(int) : lector.GetInt32(lector.GetOrdinal("f_estado")),
                            id_usuarioCreacion = lector.IsDBNull(lector.GetOrdinal("id_user_registro")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_user_registro")),
                            id_usuarioModifica = lector.IsDBNull(lector.GetOrdinal("id_user_modifica")) ? default(int) : lector.GetInt32(lector.GetOrdinal("id_user_modifica")),
                            FechaCreacion = lector.IsDBNull(lector.GetOrdinal("fecha_registro")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_registro")),
                            FechaModificacion = lector.IsDBNull(lector.GetOrdinal("fecha_modifica")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("fecha_modifica"))

                        });
                    }
                }
            }

            return paciente;
        }

        public int Update(ADM_PACIENTE entity)
        {
            int id;

            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_PACIENTE_Update")))
            {
                _database.AddInParameter(comando, "@id_paciente", DbType.Int32, entity.id_paciente);
                _database.AddInParameter(comando, "@n_historia_clinica", DbType.Int32, entity.n_historia_clinica);
                _database.AddInParameter(comando, "@t_apellido_paterno", DbType.String, entity.t_apellido_paterno);
                _database.AddInParameter(comando, "@t_apellido_materno", DbType.String, entity.t_apellido_materno);
                _database.AddInParameter(comando, "@t_nombres", DbType.String, entity.t_nombres);
                _database.AddInParameter(comando, "@t_paciente", DbType.String, entity.t_paciente);
                _database.AddInParameter(comando, "@d_fecha_nacimiento", DbType.DateTime, entity.d_fecha_nacimiento);
                _database.AddInParameter(comando, "@id_genero", DbType.Int32, entity.id_genero);
                _database.AddInParameter(comando, "@id_estado_civil", DbType.Int32, entity.id_estado_civil);
                _database.AddInParameter(comando, "@id_documento_identidad", DbType.Int32, entity.id_documento_identidad);
                _database.AddInParameter(comando, "@c_documento_identidad", DbType.String, entity.c_documento_identidad);
                _database.AddInParameter(comando, "@id_grupo_sanguineo", DbType.Int32, entity.id_grupo_sanguineo);
                _database.AddInParameter(comando, "@id_ocupacion", DbType.Int32, entity.id_ocupacion);
                _database.AddInParameter(comando, "@t_ocupacion", DbType.String, entity.t_ocupacion);
                _database.AddInParameter(comando, "@t_email_paciente", DbType.String, entity.t_email_paciente);
                _database.AddInParameter(comando, "@c_p_fono_casa", DbType.String, entity.c_p_fono_casa);
                _database.AddInParameter(comando, "@c_p_fono_personal", DbType.String, entity.c_p_fono_personal);
                _database.AddInParameter(comando, "@c_p_fono_corporativo", DbType.String, entity.c_p_fono_corporativo);
                _database.AddInParameter(comando, "@id_ubigeo_nacimiento", DbType.Int32, entity.id_ubigeo_nacimiento);
                _database.AddInParameter(comando, "@id_ubigeo_domicilio", DbType.Int32, entity.id_ubigeo_domicilio);
                _database.AddInParameter(comando, "@t_referencia", DbType.String, entity.t_referencia);
                _database.AddInParameter(comando, "@t_direccion", DbType.String, entity.t_direccion);
                _database.AddInParameter(comando, "@t_responsable", DbType.String, entity.t_responsable);
                _database.AddInParameter(comando, "@t_email_responsable", DbType.String, entity.t_email_responsable);
                _database.AddInParameter(comando, "@c_r_fono_casa", DbType.String, entity.c_r_fono_casa);
                _database.AddInParameter(comando, "@c_r_fono_personal", DbType.String, entity.c_r_fono_personal);
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
